using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Models
{
  public class MockEmployeeRepository : IEmployeeRepository
  {
		private List<Employee> _employeeList;

		public MockEmployeeRepository()
		{
			_employeeList = new List<Employee>()
			{
				new Employee() { Id = 1, Name= "Apple", Department="OGP", Email="apple@email.com"},
				new Employee() { Id = 2, Name= "Banana", Department="IAP", Email="banana@email.com"},
				new Employee() { Id = 3, Name= "Jack", Department="DSD", Email="jack@email.com"},
			};
		}

		public Employee GetEmployee(int id)
		{
			return _employeeList.Find(e => e.Id == id);
		}

		public List<Employee> GetAllEmployees()
		{
			return _employeeList;
		}

		public Employee Add(Employee employee)
		{
			employee.Id = _employeeList.Max(e => e.Id) + 1;
			_employeeList.Add(employee);

			return employee;
		}

		public Employee Update(Employee employeeChanges)
		{
			Employee employee = _employeeList.Find(e => e.Id == employeeChanges.Id);

			if (employee != null) {
				employee.Name = employeeChanges.Name;
				employee.Department = employeeChanges.Department;
				employee.Email = employeeChanges.Email;
			}

			return employee;
		}

		public Employee Delete(int id)
		{
			Employee employee = _employeeList.Find(e => e.Id == id);

			if (employee != null) {
				_employeeList.Remove(employee);
			}

			return employee;
		}
  }
}
