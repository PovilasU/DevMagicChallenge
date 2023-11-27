import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { Employee } from './models/employee';
import { DevmagicService } from './services/devmagic.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
})
export class AppComponent {
  title = 'DevMagicAngularUI';
  employees: Employee[] = [];

  constructor(private devmagicService: DevmagicService) {}

  ngOnInit(): void {
    // this.employees = this.devmagicService.getEmployees();
    console.log('this.employees test');
    console.log(this.employees);
  }
}
