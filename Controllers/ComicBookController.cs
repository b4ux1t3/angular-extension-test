using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ComicCollector.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ComicCollector.Controllers
{
    [ApiController]
    [Route("api/comicbook")]
    public class ComicBookController : ControllerBase
    {
        private readonly ILogger<ComicBookController> _logger;
        private readonly ComicBookContext _context;

        public ComicBookController(ILogger<ComicBookController> logger, ComicBookContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<ComicBook>> PostComicBook(ComicBook comicBook)
        {
            _logger.LogInformation($"Received POST: {comicBook.Title}");
            _context.ComicBooks.Add(comicBook);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetComicBook), new { id = comicBook.Id}, comicBook);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ComicBook>> GetComicBook(Guid id)
        {
            ComicBook comicBook = await _context.ComicBooks.FindAsync(id);

            if (comicBook == null) return NotFound();

            return comicBook;
        }
        [HttpGet()]
        public async Task<ActionResult<IEnumerable<ComicBook>>> GetComicBooks()
        {
            return await _context.ComicBooks.ToListAsync();
        }
    }
}