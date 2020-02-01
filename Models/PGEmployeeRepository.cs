using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace EmployeeManagement.Models
{
  public class PGEmployeeRepository : IEmployeeRepository
  {
		private readonly ILogger<PGEmployeeRepository> _logger;
		private readonly AppDbContext context;

		public PGEmployeeRepository(AppDbContext context, ILogger<PGEmployeeRepository> logger)
		{
			_logger = logger;
			this.context = context;
		}

		public Employee GetEmployee(int id)
		{
			return context.Employees.Find(id);
		}

		public List<Employee> GetAllEmployees()
		{
			_logger.LogTrace("Log Trace");
			_logger.LogDebug("Log Debug");
			_logger.LogInformation("Log Information");
			_logger.LogWarning("Log Warning");
			_logger.LogError("Log Error");
			_logger.LogCritical("Log Critical");

			return context.Employees.ToList<Employee>();
		}

		public Employee Add(Employee employee)
		{
			context.Employees.Add(employee);
			context.SaveChanges();

			return employee;
		}

		public Employee Update(Employee employeeChanges)
		{
			var employee = context.Employees.Attach(employeeChanges);
			employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			context.SaveChanges();

			return employeeChanges;
		}

		public Employee Delete(int id)
		{
			Employee employee = context.Employees.Find(id);

			if (employee != null) {
				context.Employees.Remove(employee);
				context.SaveChanges();
			}

			return employee;
		}
  }
}
