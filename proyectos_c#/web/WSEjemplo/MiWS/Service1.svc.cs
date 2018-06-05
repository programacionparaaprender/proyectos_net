using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MiWS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Servise1 : IWSProductos
    {

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public Producto ObtenerProducto(string Identificacion)
        {
            if(Identificacion == "0")
            {
                return new MiWS.Producto() { Nombre = "Chocolate", Costo = 10 };
            }else if(Identificacion == "1")
            {
                return new MiWS.Producto() { Nombre = "Café", Costo = 5 };
            }else
            {
                return new MiWS.Producto() { Error = "Producto no encontrado" };
            }
            
        }
    }
}
