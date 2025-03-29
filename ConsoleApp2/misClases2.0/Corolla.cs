public class Corrolla : Vehiculo
{
    public Corrolla(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo, 180)
    {
        CapacidadTanque = 50;
        ConsumoCombustible = 8; 
    }
}