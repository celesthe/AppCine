using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace APPCINE.Models
{
    public class Sala
    {
        [DisplayName("Codigo Sala")]
        public int Id { get; set; }
        [DisplayName("Tipo Sala")]
        public string TipoSala { get; set; }
        [DisplayName("Precio")]
        public decimal Precio { get; set; }
        [DisplayName("Codigo Pelicula")]
        public int IdPelicula { get; set; }
    }
}
