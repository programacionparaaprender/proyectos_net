using System;

namespace EjemploSingleton
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Singleton s0 = new Singleton();  //Error
			Singleton s1 = Singleton.Instance;
			Singleton s2 = Singleton.Instance;
			if (s1 == s2)
			{
				Console.WriteLine("Son iguales");
				Console.ReadKey();
			}
		}
	}
}
