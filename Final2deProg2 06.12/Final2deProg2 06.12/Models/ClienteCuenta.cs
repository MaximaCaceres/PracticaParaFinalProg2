﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final2deProg2_06._12.Models
{
    [Serializable]
    public class ClienteCuenta:IComparable, IExportable
    {
        public Queue<Pedido> listaPedidos = new Queue<Pedido>();
        public string Nombre {  get; set; }
        public long Cuit {  get; set; }
        public double SaldoCuenta {  get; set; }
        public double Tope {  get; set; }
        #region metodos
        public ClienteCuenta()
        {

        }
        public ClienteCuenta(string nomb, long cuit,double tope)
        {
            Nombre = nomb;
            Cuit = cuit;
            Tope = tope;
        }
        public double AgregarPedido(Pedido nuevo)
        {
            double t = nuevo.Valor;
            listaPedidos.Enqueue(nuevo);
            SaldoCuenta = SaldoCuenta + t;
            return t;
        }
        public Pedido RetirarPedido()
        { int cantP = 0;
            Pedido p = null;
            try
            {
                cantP = listaPedidos.Count;
                if (cantP > 1)
                {
                  p = listaPedidos.Dequeue();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"No hay pedidos en la lista!");
            }
            return p;
        }
        public bool AgregarPago(double monto)
        {
            SaldoCuenta = SaldoCuenta - monto;
            return true;
        }

        public int CompareTo(object obj)
        {
            ClienteCuenta c = obj as ClienteCuenta;
            if (c != null)
            {
                return Cuit.CompareTo(c.Cuit);
            }
            return 1;
        }
        public string DatClient()
        {
            string date = $@"Cliente: {Nombre}
                             Cuit: {Cuit}";
            return date;
        }
        public override string ToString()
        {
            string date = $"{Nombre};{Cuit};{SaldoCuenta}";
            return date;
        }
        public string Escribir()
        {
            return ToString();
            //nombre, cuit y saldo
        }
        #endregion
    }
}
