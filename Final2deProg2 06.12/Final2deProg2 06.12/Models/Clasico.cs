using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final2deProg2_06._12.Models
{
    [Serializable]
    public class Clasico:Producto,IImportable
    {
        public Clasico(double pA, string D)
        {
            precioBA = pA;
            descr = D;
        }
        public Clasico()
        {

        }
        public void Leer(string n)
        {
            string[] dat = n.Split(';');
            descr = dat[0];
            precioBA = Convert.ToDouble(dat[1]);
            //Descripcion; precioA; tipo
        }

        public override double Precio(double kg)
        {
            double tot = 50 + (precioBA * 1.4);
            return tot;
            //50 + (precioA*1.4)
        }
        public override string ToString()
        {
            string dat = $"{descr};{precioBA}";
            return dat;
        }
    }
}
