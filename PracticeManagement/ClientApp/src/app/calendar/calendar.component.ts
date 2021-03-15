import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'calendar',
  templateUrl: './calendar.component.html'
})
export class FetchDataComponent {
  public details: calendarDetail[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<calendarDetail[]>(baseUrl + 'calendarDetails').subscribe(result => {
      this.details = result;
    }, error => console.error(error));
  }
}

interface calendarDetail {

  id: number;
  appointmenStartDate: string;
  appointmenEndDate: string;

  appointmentStarTime: string;
  appointmentEndTime: string;
  publishDate: string;


  title: string;
  description: string;
  isAllDay: string;
}
