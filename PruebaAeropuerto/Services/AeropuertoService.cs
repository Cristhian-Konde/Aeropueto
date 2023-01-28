using Domio;
using Microsoft.AspNetCore.Mvc;
using PruebaAeropuerto.Models;
using System.Collections.Generic;

namespace PruebaAeropuerto.Services
{
	public class AeropuertoService : IAeropuertoService
	{
		private readonly AeropuertoDataContext _DataContext;
		public AeropuertoService(AeropuertoDataContext dataContext)
		{
			_DataContext = dataContext;
		}
		public IEnumerable<Domio.Entities.MovimientosAeropuerto> GetList()
		{
			var list = _DataContext.MovimientosAeropuerto.ToArray();
			if (list.Length >= 1)
			{
				return list;
			}
			else
			{
				return NotFound();
			}
		}

		private IEnumerable<Domio.Entities.MovimientosAeropuerto> NotFound()
		{
			throw new NotImplementedException("No hay datos que mostrar");
		}

		public IActionResult AddCatalogo(Domio.Entities.MovimientosAeropuerto movimientosAeropuerto)
		{
			Domio.Response.Respuesta oRespuesta = new Domio.Response.Respuesta();

			try
			{
				if (!string.IsNullOrEmpty(movimientosAeropuerto.Matricula))
				{
					_DataContext.MovimientosAeropuerto.Add(movimientosAeropuerto);
					_DataContext.SaveChanges();

					oRespuesta.Exito = 1;

					oRespuesta.Mensaje = "Insertado correctamente";
				}
				else
				{
					oRespuesta.Exito = 0;

					oRespuesta.Mensaje = "El nombre del Catalogo es obligatorio";
				}


			}
			catch (Exception ex)
			{

				oRespuesta.Mensaje = ex.Message;
			}

			OkObjectResult okObject = new OkObjectResult(oRespuesta);

			return okObject;


		}
	}
}
