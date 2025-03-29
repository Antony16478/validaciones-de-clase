

namespace VehiculoApp
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Chofer chofer1 = new Chofer("Carlos", 22, "A");
            Chofer chofer2 = new Chofer("Ana", 19, "B");
            Chofer chofer3 = new Chofer("Juan", 17, "A"); 

            
            Moto moto = new Moto(2025, "Negra", "Yamaha");
            Corrolla corrolla = new Corrolla(2020, "Azul", "Corolla");
            Trailer trailer = new Trailer(2023, "Blanco", "Volvo");

            Console.WriteLine("\nInformación del Vehículo:");
            moto.InformacionVehiculo();
            corrolla.InformacionVehiculo();
            trailer.InformacionVehiculo();

           
            Console.WriteLine("\nProbando Acelerar y Frenar:");
            moto.Acelerar(50);
            moto.HacerCaballito();

            moto.Frenar(30);
            moto.HacerCaballito(); 

            corrolla.Acelerar(100);
            corrolla.Frenar(50);

            trailer.Acelerar(130); 
            trailer.Frenar(130);

           
            Console.WriteLine("\nProbando Apagar Vehículos:");
            trailer.Apagar(); 
            trailer.Frenar(130); 
            trailer.Apagar(); 

           
            Console.WriteLine("\nInformación final de los vehículos:");
            moto.InformacionVehiculo();
            corrolla.InformacionVehiculo();
            trailer.InformacionVehiculo();
        }
    }
}
