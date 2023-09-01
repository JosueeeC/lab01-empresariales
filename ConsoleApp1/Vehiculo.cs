using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Vehiculo
    {
        

        public Vehiculo(string marca, string modelo, int annio){
            Marca = marca;
            Modelo = modelo;
            Annio = annio;
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Annio { get; set; }

        public virtual void mostrarInformacion()
        {
            Console.WriteLine("------");
            Console.WriteLine(Marca);
            Console.WriteLine(Modelo);
            Console.WriteLine(Annio);
        }
    }
}
