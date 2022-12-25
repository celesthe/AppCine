using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace APPCINE.Models
{
    public class Pelicula
    {
        [DisplayName("Codigo Pelicula")]
        public int Id { get; set; }
        [DisplayName("Nombre Pelicula")]
        public string nombre { get; set; }
        [DisplayName("Categoria")]
        public string Categoria { get; set; }
        [DisplayName("Genero")]
        public string Genero { get; set; } = string.Empty;

    }
}
