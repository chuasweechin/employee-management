using System;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EmployeeManagement.Controllers {
  public class ErrorController : Controller {
		private readonly ILogger<ErrorController> _logger;

		public ErrorController(ILogger<ErrorController> logger) {
      _logger = logger;
		}

		[Route("Error/{statusCode?}")]
    public string HttpStatusCodeHandler(int statusCode) {
      var statusCodeResult = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();

      switch (statusCode) {
        case 404:
          return "404";
			}

      return "some error";
		}
  }
}
