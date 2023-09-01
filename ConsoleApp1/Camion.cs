using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Camion : Vehiculo
    {

        public Camion(string Marca, string Modelo, int Annio, double CapacidadCarga) : base(Marca, Modelo, Annio)
        {

            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Annio = Annio;
            this.CapacidadCarga = CapacidadCarga;
        }

        public double CapacidadCarga {  get; set; }

        public override void mostrarInformacion()
        {
            base.mostrarInformacion();
            Console.WriteLine(CapacidadCarga);
        }
    }
}
