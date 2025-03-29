public class Chofer
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string TipoLicencia { get; set; }

    public Chofer(string nombre, int edad, string tipoLicencia)
    {
        Nombre = nombre;
        Edad = edad;
        TipoLicencia = tipoLicencia;

        ValidarLicencia();
    }

    private void ValidarLicencia()
    {
        if (TipoLicencia == "A" && Edad >= 21)
        {
            Console.WriteLine("Licencia válida para el tipo A.");
        }
        else if (TipoLicencia == "B" && Edad >= 18)
        {
            Console.WriteLine("Licencia válida para el tipo B.");
        }
        else if (TipoLicencia == "C" && Edad >= 18)
        {
            Console.WriteLine("Licencia válida para el tipo C.");
        }
        else
        {
            Console.WriteLine("Licencia no válida para este tipo.");
        }
    }
}

