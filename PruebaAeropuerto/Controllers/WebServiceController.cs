using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaAeropuerto.Services;

namespace PruebaAeropuerto.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WebServiceController : ControllerBase
	{
		private readonly IAeropuertoService _aeropuetoService;

		public WebServiceController(IAeropuertoService aeropuetoService)
		{
			_aeropuetoService = aeropuetoService;
		}

		[HttpGet(Name = "GetmovimientosList")]
		public IActionResult GetList() => Ok(_aeropuetoService.GetList());
	}
}
