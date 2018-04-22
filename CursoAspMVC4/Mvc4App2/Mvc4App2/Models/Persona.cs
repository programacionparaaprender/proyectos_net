using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc4App2.Models
{
    public class Persona
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        //apellido paterno
        public string apepat { get; set; }
        //apellido materno
        public string apemat { get; set; }


        public Persona()
        {
            // TODO: Complete member initialization
        }

        public Persona(int p1, string p2, string p3, string p4)
        {
            // TODO: Complete member initialization
            this.codigo = p1;
            this.nombre = p2;
            this.apepat = p3;
            this.apemat = p4;
        }
    }
}