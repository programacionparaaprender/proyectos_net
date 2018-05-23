using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TipoExcepcion
{
    /*
    Excepciones predefinidas comunes
    En el espacio de nombres System de la BCL hay predefinidas múltiples 
     * excepciones
    derivadas de System.Exception que se corresponden con los errores más 
     * comunes que
    pueden surgir durante la ejecución de una aplicación. En la Tabla 8 
     * se recogen algunas:
    Tipo de la excepción Causa de que se produzca la excepción
     * 
    ArgumentException Pasado argumento no válido (base de excepciones 
     * de argumentos)
     * 
    ArgumentNullException Pasado argumento nulo
     * 
    ArgumentOutOfRangeException Pasado argumento fuera de rango
     * 
    ArrayTypeMistmatchException Asignación a tabla de elemento que no es 
     * de su tipo
     * 
     COMException Excepción de objeto COM
     * 
    DivideByZeroException División por cero
     * 
    IndexOutOfRangeException Índice de acceso a elemento de tabla fuera 
     * del rango válido (menor que cero o mayor que el tamaño de la tabla)
     * 
    InvalidCastException Conversión explícita entre tipos no válida
     * 
    InvalidOperationException Operación inválida en estado actual del 
     * objeto
     * 
    InteropException Base de excepciones producidas en comunicación
    con código inseguro
     * 
    NullReferenceException Acceso a miembro de objeto que vale null
     * 
    OverflowException Desbordamiento dentro de contexto donde se ha de
    comprobar los desbordamientos (expresión constante,
    instrucción checked, operanción checked u opción
    del compilador /checked)
     * 
    OutOfMemoryException Falta de memoria para crear un objeto con new
     * 
    SEHException Excepción SHE del API Win32
     * 
    StackOverflowException Desbordamiento de la pila, generalmente debido 
     * a un excesivo número de llamadas recurrentes.
     * 
    TypeInizializationException Ha ocurrido alguna excepción al 
     * inicializar los campos estáticos o el constructor estático de 
     * un tipo.
    En InnerException se indica cuál es.
        */
    public class PrincipalMain
    {
        public static void Main(string[] args)
        {
            Console.ReadKey(true);
        }
    }
}
