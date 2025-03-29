public class Trailer : Vehiculo
{
    public Trailer(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo, 120)
    {
        CapacidadTanque = 150; 
        ConsumoCombustible = 012; 
        VelocidadMaxima = 120; 
    }
}
