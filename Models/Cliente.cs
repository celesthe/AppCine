using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace APPCINE.Models
{
    public class Cliente
    {
        [DisplayName("Codigo Cliente")]
                public int Id { get; set; }
        [DisplayName("Nombre")]
        public string nombre { get; set; }
        [DisplayName("Apellido")]
        public string apellido { get; set; }
        [DisplayName("Codigo Sala")]
        public int IdSala { get; set; }
        [DisplayName("Nit")]
        public string nit { get; set; }
    }
}
