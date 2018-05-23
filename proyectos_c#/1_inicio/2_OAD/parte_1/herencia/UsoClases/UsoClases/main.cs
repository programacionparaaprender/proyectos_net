
using System;

//acceso limitado a la clase contenedora o a los tipos derivados
class A
{
    protected int x = 123;
}
class B : A
{
    void F()
    {
        A a = new A();
        B b = new B();
        //a.x = 10; // Error
        b.x = 10; // OK
    }
}

//limitado al proyecto actual
internal class Muestra2
{
    public Muestra2()
    {
        
    }
}

protected internal class Muestra3
{
    public Muestra3()
    {
 
    }
}


public class PrincipalMain
{
    public static void Main(string args)
    {
 
    }
}