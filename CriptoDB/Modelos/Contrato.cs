using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoDB.Modelos
{
    public class Contrato
    {
        //Decide cómo vas a implementar la clave principal

        public int ContratoId { get; set; }
        //Escribe las propiedades de relación 1:N entre Moneda y Cartera
        public int CarteraId { get; set; }
        public string MonedaId { get; set; }
        public int Cantidad { get; set; }


        //Escribe las propiedades de navegación a otras Entidades

        public DbSet<Moneda> Monedas { get; set; }

        public DbSet<Cartera> Carteras { get; set; }

        // A implementar
        public override string ToString() => $"A implementar";
    }

}
