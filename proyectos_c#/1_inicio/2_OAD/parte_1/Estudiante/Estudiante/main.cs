/*Crear objeto de tipo estudiante que contenga nombre,cedula,semestre,cantidad de materias

 y nombre de las materias(nombres de las materias en un arreglo). Crear metodos (opciones)
  
 en un menu los cuales son:
 
Agregar,eliminar y mostrar lista de estudiantes,mostrar lista con estudiantes que cursan una 

determinada materia y una opcion modificar con la que puedas modificar el nombre de un
 
estudiante (si quieres puedes modificar lo demas como la cedula y los nombres de las
 
materias pero ella pidio nombre solamente, dijo eso porque si no y que iba a ser muy largo y tal)*/

namespace Estudiante
{
    public class PruebaEstudiante
    {

        public static void Main(string[] args)
        {

            Academia UDO = new Academia();

            Academia UDO1 = new Academia();

            UDO.Ingresar();

            System.Console.ReadKey(true);

        }

    }
}