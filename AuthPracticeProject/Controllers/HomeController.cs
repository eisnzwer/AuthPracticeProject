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
		/// <response code = "200"> Успешный доступ </response>
		[HttpGet("Default")]
		[ProducesResponseType(200, Type = typeof(string))]
		public IActionResult Index()
		{
			return Ok("Основной контроллер");
		}

		/// <summary>
		/// Защищенный метод для администраторов.
		/// </summary>
		/// <response code = "200"> Успешный доступ </response>
		/// <response code = "401"> Администратор не авторизован </response>
		/// <response code = "403"> Недостаточные права </response>
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
		/// <response code = "200"> Успешный доступ </response>
		/// <response code = "401"> Пользователь не авторизован </response>
		/// <response code = "403"> Недостаточные права </response>
		[HttpGet("Secured/Users")]
		[Authorize(Policy = "UsersOnly")]
		[ProducesResponseType(200, Type = typeof(string))]
		public IActionResult SecuredMethodUsers()
		{
			return Ok("Был получен доступ к защищенному методу для пользователей старше 18 лет");
		}
	}
}