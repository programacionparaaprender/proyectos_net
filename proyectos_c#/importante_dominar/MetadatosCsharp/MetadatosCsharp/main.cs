/*
Los metadatos son un conjunto de datos organizados en forma de tablas que
almacenan información sobre los tipos definidos en el módulo, los miembros de
éstos y sobre cuáles son los tipos externos al módulo a los que se les referencia en el
módulo. Los metadatos de cada modulo los genera automáticamente el compilador
al crearlo, y entre sus tablas se incluyen1:
Tabla Descripción
 * 
ModuleDef Define las características del módulo. Consta de un único elemento
que almacena un identificador de versión de módulo (GUID creado
por el compilador) y el nombre de fichero que se dio al módulo al
compilarlo (así este nombre siempre estará disponible, aunque se
renombre el fichero)
 * 
TypeDef Define las características de los tipos definidos en el módulo. De cada
tipo se almacena su nombre, su tipo padre, sus modificadores de
acceso y referencias a los elementos de las tablas de miembros
correspondientes a sus miembros.
 * 
MethodDef Define las características de los métodos definidos en el módulo. De
cada método se guarda su nombre, signatura (por cada parámetro se
incluye una referencia al elemento apropiado en la tabla ParamDef),
modificadores y posición del módulo donde comienza el código MSIL
de su cuerpo.
 * 
ParamDef Define las características de los parámetros definidos en el módulo. De
cada parámetro se guarda su nombre y modificadores.
 * 
FieldDef Define las características de los campos definidos en el módulo. De
1 No se preocupe si no entiende aún algunos de los conceptos nuevos introducido en las descripciones de
las tablas de metadatos, pues más adelante se irán explicando detalladamente.
El lenguaje de programación C# Tema 1: Introducción a Microsoft.NET
José Antonio González Seco Página 15
cada uno se almacena información sobre cuál es su nombre, tipo y
modificadores.
 * 
PropertyDef Define las características de las propiedades definidas en el módulo.
De cada una se indica su nombre, tipo, modificadores y referencias a
los elementos de la tabla MethodDef correspondientes a sus métodos
set/get.
 * 
EventDef Define las características de los eventos definidos en el módulo. De
cada uno se indica su nombre, tipo, modificadores. y referencias a los
elementos de la tabla MethodDef correspondientes a sus métodos
add/remove.
 * 
AssemblyRef Indica cuáles son los ensamblados externos a los que se referencia en
el módulo. De cada uno se indica cuál es su nombre de fichero (sin
extensión), versión, idioma y marca de clave pública.
 * 
ModuleRef Indica cuáles son los otros módulos del mismo ensamblado a los que
referencia el módulo. De cada uno se indica cuál es su nombre de
fichero.
 * 
TypeRef Indica cuáles son los tipos externos a los que se referencia en el
módulo. De cada uno se indica cuál es su nombre y, según donde
estén definidos, una referencia a la posición adecuada en la tabla
AssemblyRef o en la tabla ModuleRef.
 * 
MemberRef Indican cuáles son los miembros definidos externamente a los que se
referencia en el módulo. Estos miembros pueden ser campos, métodos,
propiedades o eventos; y de cada uno de ellos se almacena
información sobre su nombre y signatura, así como una referencia a la
posición de la tabla TypeRef donde se almacena información relativa
al tipo del que es miembro.
Tabla 1: Principales tablas de metadatos
*/

using System;

public static class PrincipalMain
{
    public static void Main(string[] args)
    {
        Console.ReadKey(true);

    }
}