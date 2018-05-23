using System;
namespace EjemploSingleton
{
public class Singleton
	{
		// Variable estática para la instancia, se necesita utilizar una función lambda ya que el constructor es privado
		private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

		// Constructor privado para evitar la instanciación directa
		private Singleton()
		{
		}

		// Propiedad para acceder a la instancia
		public static Singleton Instance
		{
			get
			{
				return instance.Value;
			}
		}
	}
}
