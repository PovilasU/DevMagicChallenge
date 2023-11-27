import { Injectable } from '@angular/core';
import { Employee } from '../models/employee';

@Injectable({
  providedIn: 'root',
})
export class DevmagicService {
  url = 'https://localhost:7287/api/DevMagic';

  constructor() {}

  // public getEmployees(): Employee[] {
  //   let employee = new Employee();
  //   employee.employeeID = 1;
  //   employee.clientID = 1;
  //   employee.officeID = 1;
  //   employee.name = 'John Doe';
  //   employee.bio = '123123The force will be with you always';
  //   employee.dateOfBirth = '2001-02-11';

  //   return [employee];
  // }

  async getEmployees(): Promise<Employee[]> {
    //this.employeeList;
    const data = await fetch(this.url);
    console.log('data');
    console.log(data);
    return (await data.json()) ?? [];
  }
}
