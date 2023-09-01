// See https://aka.ms/new-console-template for more information


using ConsoleApp1;

Vehiculo vehiculo = new Vehiculo("Toyota", "Yaris", 2022);
Camion camion = new Camion("Camion", "Rojo", 2023, 200);
Automovil automovil = new Automovil("Lambo", "A1", 2023, "250");

List<Vehiculo> vehiculos = new List<Vehiculo> { vehiculo, camion, automovil };

Flota flota = new Flota(vehiculos);



bool salir = false;

while (!salir)
{

    Console.WriteLine("1. Mostrar informacion del vehiculo");
    Console.WriteLine("2. Calcular costo de viaje");
    Console.WriteLine("3. Salir");
    Console.WriteLine("Elige una de las opciones");
    int opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            flota.mostrarFlota();
            break;

        case 2:
            Console.WriteLine("Ingresa un vehiculo");
            
            switch (Console.ReadLine())
            {
                case "Camion":
                    int km = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese una distancia");
                    int result = 200 * km;
                    Console.WriteLine("El costo es: ");
                    Console.WriteLine(result);
                    break;

                case "Automovil":
                    int xd = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese una distancia");
                    int response = 200 * xd;
                    Console.WriteLine("El costo es: ");
                    Console.WriteLine(response);
                    break;
                
            }
            

            break;

        case 3:
            Console.WriteLine("Has elegido salir de la aplicación");
            salir = true;
            break;
        default:
            Console.WriteLine("Elige una opcion entre 1 y 4");
            break;
    }

}

