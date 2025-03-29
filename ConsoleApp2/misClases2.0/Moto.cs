public class Moto : Vehiculo
{
    public Moto(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo, 150)
    {
       
        CapacidadTanque = 5; 
        ConsumoCombustible = 005; 
        VelocidadMaxima = 180; 
    }

   
    public void HacerCaballito()
    {
        if (velocidad > 0)
        {
            Console.WriteLine("¡Estás haciendo un caballito!");
        }
        else
        {
            Console.WriteLine("No puedes hacer un caballito mientras estás detenido.");
        }
    }
}
