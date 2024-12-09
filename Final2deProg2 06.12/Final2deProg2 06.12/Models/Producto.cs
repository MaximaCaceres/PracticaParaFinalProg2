using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final2deProg2_06._12.Models
{
    [Serializable]
    public abstract class Producto
    {
        protected string descr = "";
        protected double precioBA = 100;
        public double CantidadKg {  get; set; }
        #region metodos
        public virtual double Precio(double kgs)
        {
            CantidadKg = kgs;
            double c = precioBA * kgs;
            return c;
        }
        public string Descripcion()
        {
            string dat = $@"Producto   Peso    PrecioU   Precio
                           {descr}    {CantidadKg:f2}   {precioBA:f2}   {Precio(CantidadKg):f2}
                          
                           Total: {precioBA + Precio(CantidadKg):f2}";
            return dat;
        }
        #endregion
    }
}
