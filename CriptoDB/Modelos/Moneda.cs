using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoDB.Modelos
{
    public class Moneda
    {
        //Clave Principal String
        [Key]
        public string MonedaId { get; set; }
        public decimal Actual { get; set; }
        public decimal Maximo { get; set; }

        //Escribe las propiedades de navegación a otras Entidades

        // A implementar
        public override string ToString() => $"A implementar";
    }
}
