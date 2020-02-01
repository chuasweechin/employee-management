using System.Collections.Generic;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.Extensions.Logging;
using EmployeeManagement.Events;
using System.Linq;
using EmployeeManagement.Mediator;

namespace EmployeeManagement.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class HomeController : Controller
	{
			private readonly IDog _doodle;
			private readonly IEmployeeRepository _employeeRepository;
			private readonly ILogger<HomeController> _logger;
			private readonly IMediatorService _mediatorService;

			public HomeController(IEmployeeRepository employeeRepository, IDog doodle, ILogger<HomeController> logger, IMediatorService mediatorService)
			{
				_mediatorService = mediatorService;
				_employeeRepository = employeeRepository;
				_doodle = doodle;
				_logger = logger;
			}	

			[HttpGet]
			public IEnumerable<Employee> Index() {
				//throw new Exception("Error in details");
				_logger.LogTrace("Log Trace");
				_logger.LogDebug("Log Debug");
				_logger.LogInformation("Log Information");
				_logger.LogWarning("Log Warning");
				_logger.LogError("Log Error");
				_logger.LogCritical("Log Critical");

				_doodle.Said();
				//_mediatorService.Notify("Notify Apple");
				_mediatorService.Query("Query Apple");

				return _employeeRepository.GetAllEmployees();
			}
			
			[Route("{id}")]
			public JsonResult Details(int id)
			{
				Employee model = _employeeRepository.GetEmployee(id);
				return Json(model);
			}

			[HttpPost]
			public Employee Create(Employee employee)
			{
				Console.WriteLine(employee.Name);

				Employee added = _employeeRepository.Add(employee);
				Console.WriteLine(_employeeRepository.GetAllEmployees().Count);
				return added;
			}
  }
}
