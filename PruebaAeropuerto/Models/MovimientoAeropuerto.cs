using System.ComponentModel.DataAnnotations;

namespace PruebaAeropuerto.Models
{
	public class MovimientoAeropuerto
	{
		public string Matricula { get; set; } = string.Empty;
		public string TipoAvion { get; set; } = string.Empty;

		public string Aerolinea { get; set; } = string.Empty;
		public string FechaAterizaje { get; set; } = DateTime.Now.ToString("MM/dd/yyyy");

		public string HoraAterrizaje { get; set; } = DateTime.Now.ToString("hh:mm");
	}
}
