using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Flota
    {
        public Flota(List<Vehiculo> vehiculos) {
            this.vehiculos = vehiculos;
        }

        public List<Vehiculo> vehiculos { get; set; }

        public void mostrarFlota()
        {
            vehiculos.ForEach(v =>
            {
                v.mostrarInformacion();
            });
        }
    }
}
