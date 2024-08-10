using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExcepciones
{
    public class Operaciones
    {

        public double n1 { get; set; }
        public double n2 { get; set; }


        public double Suma(double n1, double n2)
        {

            return n1 + n2;
        }

        public double Resta(double n1, double n2)
        {

            return n1 - n2;
        }

        public double multiplicacion(double n1, double n2)
        {

            return n1 * n2;
        }

        public double Division(double n1, double n2)
        {

            return n1 / n2;
        }
    }
}
