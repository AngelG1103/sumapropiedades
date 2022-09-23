using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumapropiedades
{
    class suma
    {
        private double v1;
        private double v2;

        public double V1 { get => v1; set => v1 = value; }
        public double V2 { get => v2; set => v2 = value; }
         public double sumar()
        {
            return V1 + V2;
        }
    }
}
