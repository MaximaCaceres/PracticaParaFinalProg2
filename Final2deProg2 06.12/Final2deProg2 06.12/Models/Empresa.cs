using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final2deProg2_06._12.Models
{
    [Serializable]
    public class Empresa
    {
        private long cuit = 0;
        public string RazonSocial {  get; set; }
        public string Direccion {  get; set; }
        #region metodos
        public Empresa(long cuit,string razon)
        {
            this.cuit = cuit;
            RazonSocial = razon;
        }
        public override string ToString()
        {
            string dat = $"{cuit};{RazonSocial};{Direccion}\n";
            return dat;
        }
        #endregion
    }
}
