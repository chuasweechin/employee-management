using System;
using System.Collections.Generic;

namespace EmployeeManagement.Models
{
  public interface IEmployeeRepository
  {
		Employee GetEmployee(int id);
		List<Employee> GetAllEmployees();
		Employee Add(Employee employee);
		Employee Update(Employee employeeChanges);
		Employee Delete(int id);
  }
}
