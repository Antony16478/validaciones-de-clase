public class Vehiculo
{
    public string Color { get; set; }
    public string Modelo { get; }
    public int Year { get; }

    protected int velocidad = 0;
    protected int velocidadMaxima;
    protected string estadoVehiculo = "Apagado"; 

    protected int CapacidadTanque { get; set; }
    protected int ConsumoCombustible { get; set; }
    protected int VelocidadMaxima { get; set; }

    public Vehiculo(int anio, string elColor, string elModelo, int velocidadMaxima)
    {
        this.Color = elColor;
        this.Modelo = elModelo;
        this.Year = anio;
        this.velocidadMaxima = velocidadMaxima;
    }

    public void InformacionVehiculo()
    {
        Console.WriteLine("Color: {0}", this.Color);
        Console.WriteLine("Modelo: {0}", this.Modelo);
        Console.WriteLine("Año: {0}", this.Year);
        Console.WriteLine("Velocidad Actual: {0} km/h", velocidad);
        Console.WriteLine("Velocidad Máxima: {0} km/h", velocidadMaxima);
        Console.WriteLine("Estado del vehículo: {0}", estadoVehiculo);
    }

    public virtual void Acelerar(int cuanto)
    {
        if (velocidad + cuanto > velocidadMaxima)
        {
            Console.WriteLine("¡Alerta! No se puede superar la velocidad máxima de {0} km/h.", velocidadMaxima);
            velocidad = velocidadMaxima;
        }
        else
        {
            velocidad += cuanto;
        }
        estadoVehiculo = "En movimiento";
        Console.WriteLine("Vas a {0} km/h", velocidad);
    }

    public void Frenar(int cuanto)
    {
        velocidad -= cuanto;
        if (velocidad < 0) velocidad = 0;
        if (velocidad == 0) estadoVehiculo = "Encendido"; 
        Console.WriteLine("Has frenado. Velocidad actual: {0} km/h", velocidad);
    }

    public void Apagar()
    {
        if (velocidad == 0)
        {
            estadoVehiculo = "Apagado";
            Console.WriteLine("El vehículo ha sido apagado.");
        }
        else
        {
            Console.WriteLine("No se puede apagar el vehículo en movimiento.");
        }
    }
}
