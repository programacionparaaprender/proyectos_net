using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TiempoAtributo
{
    [assembly: EjemploEnsamblado]
    [module: EjemploModulo]
    [AttributeUsage(AttributeTargets.Method)]
    class EjemploMétodo:Attribute
    {
    }
    [AttributeUsage(AttributeTargets.Assembly)]
    class EjemploEnsamblado:Attribute
    {
    }
    [AttributeUsage(AttributeTargets.Module)]
    class EjemploModulo:Attribute
    {
    }
    [AttributeUsage(AttributeTargets.Class)]
    class EjemploTipo:Attribute
    {
    }
    [AttributeUsage(AttributeTargets.Field)]
    class EjemploCampo:Attribute
    {
    }
    [EjemploTipo]
    class A
    {
        public static void Main(string[] args)
        {
            Assembly ensamblado = Assembly.GetExecutingAssembly();
            foreach (Attribute 
                atributo in Attribute.GetCustomAttributes(ensamblado))
                Console.WriteLine("ENSAMBLADO: {0}",atributo);
            foreach (Module modulo in ensamblado.GetModules())
            {
                foreach(Attribute 
                    atributo in Attribute.GetCustomAttributes(modulo))
                    Console.WriteLine("MODULO: {0}", atributo);
                foreach (Type tipo in modulo.GetTypes())
                {
                    foreach(Attribute 
                        atributo in Attribute.GetCustomAttributes(tipo))
                        Console.WriteLine("TIPO: {0}", atributo);
                    foreach (FieldInfo campo in tipo.GetFields())
                        muestra("CAMPO", campo);
                    foreach (MethodInfo 
                        metodo in tipo.GetMethods())
                        muestra("METODO", metodo);
                    foreach (EventInfo 
                        evento in tipo.GetEvents())
                        muestra("EVENTO", evento);
                    foreach (PropertyInfo 
                        propiedad in tipo.GetProperties())
                        muestra("PROPIEDAD", propiedad);
                    foreach (ConstructorInfo 
                        constructor in tipo.GetConstructors())
                        muestra("CONSTRUCTOR",constructor);
                }
            }
            Console.ReadKey(true);
        }
        static private void muestra(string nombre, MemberInfo miembro)
        {
            foreach (Attribute 
                atributo in Attribute.GetCustomAttributes(miembro))
                Console.WriteLine("{0}: {1}", nombre, atributo);
        }
    }
}
