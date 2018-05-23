
using System;

namespace UsoAbstract
{
    public class PrincipalMain
    {
        public static void Main(string[] args)
        {
            Animal perro = new Perro(4,"samuel");
            Animal pelicano = new Pajaro(2,"santos");

            perro.alimentos();
            perro.mover();

            pelicano.alimentos();
            pelicano.mover();

            Console.ReadKey(true);
        }
    }
}