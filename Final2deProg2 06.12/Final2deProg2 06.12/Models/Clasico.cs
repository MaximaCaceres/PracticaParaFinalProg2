using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final2deProg2_06._12.Models
{
    [Serializable]
    public class Clasico:Producto
    {
        public Clasico(double pA, string D)
        {
            precioBA = pA;
            descr = D;
        }
        public double Precio(double kg)
        {
            double tot = 50 + (precioBA * 1.4);
            return tot;
            //50 + (precioA*1.4)
        }
    }
}
