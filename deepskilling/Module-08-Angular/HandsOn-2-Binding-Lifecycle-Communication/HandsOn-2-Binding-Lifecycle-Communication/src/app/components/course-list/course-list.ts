import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CourseCard } from '../course-card/course-card';


@Component({
  selector: 'app-course-list',
  imports: [
    CommonModule,
    CourseCard
  ],
  templateUrl: './course-list.html',
  styleUrl: './course-list.css'
})
export class CourseList {


  courses = [

    {
      id: 1,
      name: 'Angular',
      code: 'ANG101',
      credits: 4
    },

    {
      id: 2,
      name: 'Java',
      code: 'JAVA101',
      credits: 3
    },

    {
      id: 3,
      name: 'SQL',
      code: 'SQL101',
      credits: 2
    },

    {
      id: 4,
      name: 'Python',
      code: 'PY101',
      credits: 4
    },

    {
      id: 5,
      name: 'React',
      code: 'REACT101',
      credits: 3
    }

  ];


  selectedCourseId: number = 0;


  onEnroll(courseId: number) {

    console.log(
      'Enrolling in course: ' + courseId
    );


    this.selectedCourseId = courseId;

  }


}