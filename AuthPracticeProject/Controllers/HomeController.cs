using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AuthPracticeProject.Controllers;

	public class HomeController : Controller
	{
		[HttpGet("")]
		public IActionResult Index()
		{
			return Ok("Основной контроллер");
		}

		[HttpGet("Secured")]
		[Authorize]
		public IActionResult SecuredMethod()
		{
			return Ok("Был получен доступ к защищенному методу");
		}
	}