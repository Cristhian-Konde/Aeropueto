using Microsoft.AspNetCore.Mvc;
using PruebaAeropuerto.Models;
using PruebaAeropuerto.Services;
using System.Diagnostics;

namespace PruebaAeropuerto.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
		private readonly IAeropuertoService _aeropuetoService;

		public HomeController(ILogger<HomeController> logger, IAeropuertoService aeropuetoService)
        {
            _logger = logger;
			_aeropuetoService = aeropuetoService;
		}

        public IActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public IActionResult SaveMovimeintos([FromBody] Domio.Entities.MovimientosAeropuerto _data)
		{
			return Ok(_aeropuetoService.AddCatalogo(_data));
		}

		public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}