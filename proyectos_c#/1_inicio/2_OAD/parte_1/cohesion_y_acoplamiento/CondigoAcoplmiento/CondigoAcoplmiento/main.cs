using System;

namespace CodigoAcoplamiento
{
    class AltoAcomplamiento
    {
        public void SaludarEnIngles(string type)
        {
            switch (type)
            {
                case "GM":
                    Console.WriteLine("Good Morning");
                    break;
                case "GE":
                    Console.WriteLine("Good Evening");
                    break;
                case "GN":
                    Console.WriteLine("Good Night");
                    break;
            }
        }
    }

    public class AltoAcoplamiento2
    {
        public static void Main(String[] args)
        {
            var ejemplo = new AltoAcomplamiento();
            ejemplo.SaludarEnIngles("GM");
            Console.ReadKey(true);
        }
    }
}
