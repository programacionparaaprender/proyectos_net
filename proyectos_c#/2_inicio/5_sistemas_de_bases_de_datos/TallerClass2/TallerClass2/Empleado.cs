using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TallerClass2
{
    public class Empleado
    {
        private string nombre,apellido,cedula,fechaN;
        private int edad;
        public Empleado(string nombre,string apellido,string cedula,string fecha)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.fechaN = fecha;
            DateTime hoy = DateTime.Now;
            DateTime fechaN = DateTime.Parse(fecha);
            this.edad = hoy.Year - fechaN.Year;
            if (hoy < fechaN.AddYears(edad))
            {
                this.edad--;
            }
        }
        public Empleado()
        {
        }
        public string Nombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public string Apellido
        {
            set { this.apellido = value; }
            get { return this.apellido; }
        }

        public string Cedula
        {
            set { this.cedula = value; }
            get { return this.cedula; }
        }

        public string FechaN
        {
            set { this.fechaN = value; }
            get { return this.fechaN; }
        }

        public int Edad
        {
            set { this.edad = value; }
            get { return this.edad; }
        }


        public string toString()
        {
            return this.nombre + this.apellido + this.fechaN + this.cedula;
        }
        
    }
}
