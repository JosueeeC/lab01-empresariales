using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Automovil : Vehiculo
    {
        public Automovil(string Marca, string Modelo, int Annio, string Combustible) : base(Marca, Modelo, Annio)
        {
            this.Combustible = Combustible;
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Annio = Annio;
        }

        public string Combustible { get; set; }

        public override void mostrarInformacion()
        {
            base.mostrarInformacion();
            Console.WriteLine(Combustible);
        }
    }
}
