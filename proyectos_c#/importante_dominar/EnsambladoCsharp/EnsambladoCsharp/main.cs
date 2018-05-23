/*
Las principales tablas incluidas en los manifiestos son las siguientes:
Tabla Descripción

 * AssemblyDef Define las características del ensamblado. Consta de un único
elemento que almacena el nombre del ensamblado sin
extensión, versión, idioma, clave pública y tipo de algoritmo
de dispersión usado para hallar los valores de dispersión de la
tabla FileDef.

 * FileDef Define cuáles son los archivos que forman el ensamblado. De
cada uno se da su nombre y valor de dispersión. Nótese que
sólo el módulo que contiene el manifiesto sabrá qué ficheros
que forman el ensamblado, pero el resto de ficheros del mismo
no sabrán si pertenecen o no a un ensamblado (no contienen
metadatos que les indique si pertenecen a un ensamblado)
 * 
ManifestResourceDef Define las características de los recursos incluidos en el
módulo. De cada uno se indica su nombre y modificadores de
acceso. Si es un recurso incrustado se indica dónde empieza
dentro del PE que lo contiene, y si es un fichero independiente
se indica cuál es el elemento de la tabla FileDef
correspondiente a dicho fichero.
 * 
ExportedTypesDef Indica cuáles son los tipos definidos en el ensamblado y
accesibles desde fuera del mismo. Para ahorrar espacio sólo
recogen los que no pertenezcan al módulo donde se incluye el
manifiesto, y de cada uno se indica su nombre, la posición en
la tabla FileDef del fichero donde se ha implementado y la
posición en la tabla TypeDef correspondiente a su definición.
 * 
AssemblyProccesorDef Indica en qué procesadores se puede ejecutar el ensamblado, lo
que puede ser útil saberlo si el ensamblado contiene módulos
con código nativo (podría hacerse usando C++ con
extensiones gestionadas) Suele estar vacía, lo que indica que se
puede ejecutar en cualquier procesador; pero si estuviese llena,
cada elemento indicaría un tipo de procesador admitido según
el formato de identificadores de procesador del fichero
WinNT.h incluido con Visual Studio.NET (por ejemplo, 586 =
Pentium, 2200 = Arquitectura IA64, etc.)
 * 
AssemblyOSDef Indica bajo qué sistemas operativos se puede ejecutar el
ensamblado, lo que puede ser útil si contiene módulos con
tipos o métodos disponibles sólo en ciertos sistemas. Suele
estar vacía, lo que indica que se puede ejecutar en cualquier
procesador; pero si estuviese llena, indicaría el identificador de
cada uno de los sistemas admitidos siguiendo el formato del
WinNT.h de Visual Studio.NET (por ejemplo, 0 = familia
Windows 9X, 1 = familia Windows NT, etc.) y el número de la
versión del mismo a partir de la que se admite.
Tabla 2: Principales tablas de un manifiesto
*/
using System;

public class PrincipalMain
{
    public static void Main(string[] args)
    {
        Console.ReadKey(true);
    }
}