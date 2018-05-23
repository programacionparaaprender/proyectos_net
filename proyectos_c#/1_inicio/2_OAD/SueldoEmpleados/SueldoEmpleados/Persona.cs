using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SueldoEmpleados
{
    public abstract class Persona
    {
        protected string nombre;
        protected string id;

        public Persona() 
        {
            this.nombre = "luis";
            this.id = "23";
        }
        public Persona(string nombre,string id)
        {
            this.nombre = nombre;
            this.id = id;
        }
        public string Nombre
        {
            set 
            {
                this.nombre = value;
            }
            get
            {
                return this.nombre;
            }
        }
        public string Id
        {
            set
            {
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }
        public string toString()
        {
            return "nombre: "+this.nombre +" id: "+this.id; 
        }
    }
}
