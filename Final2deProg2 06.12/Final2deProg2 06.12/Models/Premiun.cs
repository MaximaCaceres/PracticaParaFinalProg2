using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final2deProg2_06._12.Models
{
    [Serializable]
    public class Premiun:Producto,IImportable
    {
        private double precioBaseB = 0;
        public Premiun(string des,double pA,double pB)
        {
            descr = des;
            precioBA = pA;
            precioBaseB = pB;
        }
        public Premiun()
        {

        }
        public void Leer(string n)//recibe la linea.
        {
            string[] dat = n.Split(';');
            descr = dat[0];
            precioBA = Convert.ToDouble(dat[1]);
            precioBaseB = Convert.ToDouble(dat[2]);
            //Descripcion; precioA; precioB; tipo
        }

        public override double Precio(double kg)
        {
            double tot = 70 + (precioBA * 0.85 + precioBaseB * 0.15) * 1.8;
            return tot;
            //70 + (precioA*0.85 + precioB *0.15)*1.8
        }
        public override string ToString()
        {
            string dat = $"{descr};{precioBA};{precioBaseB}";
            return dat;
        }
    }
}
