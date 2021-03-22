import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-calendar',
  templateUrl: './calendar-detail.component.html'
})
export class CalendarEntryComponent {
  public details: CalendarEntry[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<CalendarEntry[]>(baseUrl + 'CalendarEntry').subscribe(result => {
      this.details = result;
    }, error => console.error(error));
  }
}

interface CalendarEntry {

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
