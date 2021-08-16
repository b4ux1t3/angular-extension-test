using System;

namespace ComicCollector.Data
{
    public class ComicBook {
        public string Publisher { get; set; }
        public string Series { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public uint Collected { get; set; }
        public uint Wanted { get; set; }
        public bool Read { get; set; }
        public Guid Id { get; protected set; }

        public ComicBook(string publisher, string series, string title, DateTime releaseDate)
        {
            Publisher = publisher;
            Series = series;
            Title = title;
            ReleaseDate = releaseDate;
            Collected = 0;
            Wanted = 0;
            Read = false;
            Id = new Guid();
        }
    }
}