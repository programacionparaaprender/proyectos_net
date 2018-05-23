


private abstract class A
{
    private string nombre;
    public A()
    {
 
    }
    public A(string nombre)
    {
        this.nombre = nombre;
    }
    public abstract int F();// esto con virtual daria error
                            //es mejor que virtual
}

private class B:A
{
    public B(string nombre)
        : base(nombre)
    {
 
    }
    public sealed override int F() // F() deja de ser redefinible
    {
        return 0;
    }
}

private class C
{
    public C()
    { 
    }
    //public virtual void otra(); esto daria error

    public virtual void mostrar()
    {
        System.Console.WriteLine("interesante");
    }
}

public class PrincipalMain
{
    public static void Main(string[] args)
    {
        C cs = new C();
        cs.mostrar();
        System.Console.ReadKey(true);
    }
}