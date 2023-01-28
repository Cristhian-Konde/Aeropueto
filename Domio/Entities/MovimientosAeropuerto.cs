using Domio.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domio.Entities
{
    [Table("MovimientosAeropuerto", Schema = "config")]
    public class MovimientosAeropuerto : Entidad<int>
    {
        [StringLength(100)]
        public string? Matricula { get; set; } 
        [StringLength(100)]
        public string? TipoAvion { get; set; }  
        [StringLength(100)]
        public string? Aerolinea { get; set; } 
        [StringLength(100)]
        public string? FechaAterizaje { get; set; } 
        [StringLength(100)]
        public string? HoraAterrizaje { get; set; } 
    }
}
