using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthPracticeProject.Controllers
{
	/// <summary>
	/// Контроллер для управления домашней страницей.
	/// </summary>
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}
        
		/// <summary>
		/// Основной контроллер для всех пользователей
		/// </summary>
		[HttpGet("Default")]
		[ProducesResponseType(200, Type = typeof(string))]
		public IActionResult Index()
		{
			return Ok("Основной контроллер");
		}

		/// <summary>
		/// Защищенный метод для администраторов.
		/// </summary>
		[HttpGet("Secured/Admin")]
		[Authorize(Policy = "AdminOnly")]
		[ProducesResponseType(200, Type = typeof(string))]
		public IActionResult SecuredMethodAdmin()
		{
			return Ok("Был получен доступ к защищенному методу для админов");
		}

		/// <summary>
		/// Защищенный метод для пользователей старше 18 лет
		/// </summary>
		[HttpGet("Secured/Users")]
		[Authorize(Policy = "UsersOnly")]
		[ProducesResponseType(200, Type = typeof(string))]
		public IActionResult SecuredMethodUsers()
		{
			return Ok("Был получен доступ к защищенному методу для пользователей старше 18 лет");
		}
	}
}