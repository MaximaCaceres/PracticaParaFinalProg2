using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final2deProg2_06._12.Models
{
    [Serializable]
    public class Pedido:IExportable
    {
        public double Valor { get; set; }
        public int Nro { get; set; }
        public DateTime FechaHora
        {
            get
            {
                return DateTime.Now;
            }
        }
        public string Detalle {  get; set; }
        #region metodos
        public Pedido(int nro, List<Producto> listap)
        {   
            Nro = nro;
            foreach (Producto p in listap)
            {
                Valor += p.Precio(p.CantidadKg);
            }
        }
        public string VerResumen()
        {
            string date = $@"{$"Nro Pedido: {Nro}",10}
{$"Fecha y Hora: {FechaHora}",10}
{$"Valor: {Valor:f2}",10}
{$"Detalle: {Detalle}",10}";
            return date;
        }

        public string Escribir()
        {
            string date = $"{Nro};{FechaHora};{Detalle};{Valor:f2}";
            //numero, fecha, detalle y valor
            return date;
        }
        #endregion
    }
}
