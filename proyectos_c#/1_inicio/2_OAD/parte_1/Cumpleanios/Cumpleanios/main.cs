

class Persona
{
    private string Nombre; // Campo de cada objeto Persona que almacena su nombre
    private int Edad; // Campo de cada objeto Persona que almacena su edad
    private string NIF; // Campo de cada objeto Persona que almacena su NIF

    public Persona()
    {
        this.Edad = 0;
        this.Nombre = "Jose";
        this.NIF = "";
    }
    public Persona (string nombre, int edad, string nif) // Constructor
    {   
        this.Nombre = nombre;
        this.Edad = edad;
        this.NIF = nif;
    }

    public void Cumpleanios() // Incrementa en uno de la edad del objeto Persona
    {
        System.Console.WriteLine("cumple "+this.Nombre+" "+(this.Edad+1)+" año");
        System.Console.WriteLine("NIF "+this.NIF);
        Edad++;
    }
}

public class PrincipalMain
{
    public static void Main(string[] args)
    {
        //Persona Persona1 = new Persona();
        Persona Persona1 = new Persona("José", 22, "12344321-A");
        Persona1.Cumpleanios();
        System.Console.ReadKey(true);
    }
}