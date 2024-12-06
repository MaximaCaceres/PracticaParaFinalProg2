using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final2deProg2_06._12.Models
{
    [Serializable]
    public class Premiun:Producto
    {
        private double precioBaseB = 0;
        public Premiun(string des,double pA,double pB)
        {
            descr = des;
            precioBaseB = pA;
            precioBaseB = pB;
        }
        public double Precio(double kg)
        {
            double tot = 70 + (precioBA * 0.85 + precioBaseB * 0.15) * 1.8;
            return tot;
            //70 + (precioA*0.85 + precioB *0.15)*1.8
        }
    }
}
