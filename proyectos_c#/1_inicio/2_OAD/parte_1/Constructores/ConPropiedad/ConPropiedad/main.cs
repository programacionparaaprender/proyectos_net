

using System; 

class ClaseConPropiedades 
{ 
    string nombre; 
    System.DateTime fechaAlta; 
    public string Nombre 
    { 
        get 
        { 
            return nombre; 
        } 
        set 
        {
            nombre = value;
        } 
    } 

    public DateTime FechaAlta 
    { 
        get 
        { 
            return fechaAlta;
        } 
    } 
    public ClaseConPropiedades(string nombre)
        //El constructor inicializa 
        // fechaAlta 
    { 
        fechaAlta = System.DateTime.Now; 
        this.nombre = nombre; 
    } 
    static void Main() 
    { 
        ClaseConPropiedades ccp = 
            new ClaseConPropiedades("Posadas");
        Console.WriteLine(
            "El cliente {0} se dio de alta en {1}", 
            ccp.Nombre, ccp.FechaAlta); 
        //ccp.FechaAlta = new DateTime(2000, 1, 1, 0, 0, 0); 
        //Error
        Console.ReadKey(true);
    } 
}