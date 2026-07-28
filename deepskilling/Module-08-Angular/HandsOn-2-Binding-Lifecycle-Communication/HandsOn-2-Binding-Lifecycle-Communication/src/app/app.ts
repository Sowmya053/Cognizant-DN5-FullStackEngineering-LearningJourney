import { Component } from '@angular/core';
import { Home } from './home/home';
import { CourseList } from './components/course-list/course-list';

@Component({
  selector: 'app-root',
  imports: [Home, CourseList],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {

}