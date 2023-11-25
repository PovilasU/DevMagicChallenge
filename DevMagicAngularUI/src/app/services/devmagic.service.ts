import { Injectable } from '@angular/core';
import { Employee } from '../models/employee';

@Injectable({
  providedIn: 'root',
})
export class DevmagicService {
  constructor() {}

  public getEmployees(): Employee[] {
    let employee = new Employee();
    employee.employeeID = 1;
    employee.clientID = 1;
    employee.officeID = 1;
    employee.name = 'John Doe';
    employee.bio = 'The force will be with you always';
    employee.dateOfBirth = '2001-02-11';

    return [employee];
  }
}
