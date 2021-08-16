import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-comic-book-list',
  templateUrl: './comic-book-list.component.html',
  styleUrls: ['./comic-book-list.component.css']
})
export class ComicBookListComponent implements OnInit {
  @ViewChild('comicForm', {static: false}) comicForm: NgForm;
  constructor() { }

  ngOnInit() {
  }

  onSubmit(){

  }
}
