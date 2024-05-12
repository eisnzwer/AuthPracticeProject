using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthPracticeProject.Controllers;

	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}
		
		[HttpGet("")]
		public IActionResult Index()
		{
			return Ok("Основной контроллер");
		}

		[HttpGet("Secured/Admin")]
		[Authorize(Policy = "AdminOnly")]
		public IActionResult SecuredMethodAdmin()
		{
			return Ok("Был получен доступ к защищенному методу для админов");
		}

		[HttpGet("Secured/Users")]
		[Authorize(Policy = "UsersOnly")]
		public IActionResult SecuredMethodUsers()
		{
			return Ok("Был получен доступ к защищенному методу для пользователей старше 18 лет");
		}
		
	}