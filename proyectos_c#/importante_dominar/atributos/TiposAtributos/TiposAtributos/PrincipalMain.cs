using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiposAtributos
{
    /*
     *• assembly: Indica que el atributo se aplica al ensamblado en que 
     *se compile el código fuente que lo contenga. Al definir atributos 
     *de ensamblado es obligatorio incluir este indicador, ya que estos 
     *atributos se colocan precediendo cualquier definición de clase o 
     *espacio de nombres y si no se incluyesen se confundiría
    con atributos de tipo, que se colocan en el mismo sitio.
     * 
    • module: Indica que el atributo se aplica al módulo en que se compile el código
    fuente que lo contenga. Al igual que el indicador assembly, hay que incluirlo
    siempre para definir este tipo de atributos porque si no se confundirían con
    atributos de tipo, ya que también se han de ubicar precediendo las definiciones
    de clases y espacios de nombres.
     * 
    • type: Indica que el atributo se aplica al tipo cuya definición precede. En realidad
    no hace falta utilizarlo, pues es lo que por defecto se considera para todo atributo
    que preceda a una definición de tipo. Sin embargo, se ha incluido por
    consistencia con el resto de indicadores de tipo de atributo y porque puede
    resultar conveniente incluirlo ya que explicitarlo facilita la lectura del código.
    
     * • return: Indica que el atributo se aplica a un valor de retorno de un método,
    operador, bloque get, o definición de delegado. Si no se incluyese se
    consideraría que se aplica a la definición del método, operador, bloque get o
    delegado, ya que estos atributos se colocan antes de la misma al igual que los
    atributos de valores de retorno.
     * 
    • param: Indica que el atributo se aplica a un parámetro de un método. Si no se
    incluyese al definir bloques set, add o remove se consideraría que el atributo se
    refiere a los bloques en sí y no al parámetro value en ellos implícito.
     *
     method: Indica que el atributo se aplica al método al que precede. En realidad no
    es necesario usarlo porque, como se dice en la explicación de los indicadores
    param y return, es lo que se considera por defecto. Sin embrago, y como pasaba
    con type, se incluye por consistencia y porque puede ser buena idea incluirlo
    para facilitar la legibilidad del código con su explicitación.
    
     * • event: Indica que el atributo se aplica al evento a cuya definición precede. En
    realidad no es necesario incluirlo porque es lo que se considera por defecto, pero
    nuevamente se ha incluido por consistencia y para facilitar la lectura del código.
    
     * • property: Indica que el atributo se aplica a la propiedad a cuya definición
    precede. Éste también es es un indicador innecesario e incluido tan sólo por
    consistencia y para facilitar la legibilidad del código.
    
     * • field: Indica que el atributo se aplica al cuya definición precede. Como otros
    indicadores, sólo se incluye por consistencia y para hacer más legible el código.
         * */
    public class PrincipalMain
    {
        public static void Main(string[] args)
        {
            MessageBox.Show("Hi there! My name is ");
            //Console.ReadKey(true);
        }
    }
}
