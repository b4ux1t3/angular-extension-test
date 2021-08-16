import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  ngOnInit(): void {
    const data = {"publisher":"marvel","series":"thor","title":"Mjolnir Strips Tonight","releaseDate":new Date(1989, 5, 11),"collected":0,"wanted":1,"read":false};

    const request = fetch("api/comicbook", {method: "POST", headers: {"Content-Type": "application/json"}, body: JSON.stringify(data)}).then(response => response.json()).then(returnData => console.log(returnData));
  }
}
