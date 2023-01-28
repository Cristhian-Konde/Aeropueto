using Microsoft.AspNetCore.Mvc;

namespace PruebaAeropuerto.Services
{
	public interface IAeropuertoService
	{
		public IEnumerable<Domio.Entities.MovimientosAeropuerto> GetList();
		public IActionResult AddCatalogo(Domio.Entities.MovimientosAeropuerto movimientoAeropuerto);

	}
}
