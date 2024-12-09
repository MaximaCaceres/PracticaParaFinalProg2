using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final2deProg2_06._12.Models
{
    [Serializable]
    public class GestionVentas
    {
        public List<ClienteCuenta>listaClientes = new List<ClienteCuenta>();
        public List<Producto> listaProductos = new List<Producto>();
        private Empresa duenio = null;
        private double montoFacturado = 0;
        private DateTime InicioOperaciones
        {
            get
            {
                return DateTime.Now;
            }
        }
        #region metodos
        public GestionVentas(long cu,string rSocial)
        {
            duenio = new Empresa(cu,rSocial);
        }
        public void AgregarCliente(ClienteCuenta client)
        {
            listaClientes.Add(client);
        }
        public ClienteCuenta BuscarCliente(long cui)
        {
            ClienteCuenta c = null;
            ClienteCuenta cu = new ClienteCuenta(null, cui, 0);
            listaClientes.Sort();
            int idx = listaClientes.BinarySearch(cu);
            if(idx <= -1)
            {
                c = null;
            }
            else
            {
                c = listaClientes[idx];
            }
            return c;
        }
        public Pedido GenerarPedido(int nroP, List<Producto> list)
        {
            Pedido p = new Pedido(nroP,list);
            return p;
        }
        public bool SumarPedido(ClienteCuenta cli, Pedido p)
        {
            cli.AgregarPedido(p);
            return true;
        }
        public bool AgregarPago(long cu, double monto)
        {
            bool ok = false;
            ClienteCuenta c = BuscarCliente(cu);
            if (c != null)
            {
                c.AgregarPago(monto);
                montoFacturado += monto;
                ok = true;
            }
            else
            {
                MessageBox.Show("Cuenta del cliente no existe");
            }
            return ok;
        }
        public double VerSaldo(long cu)
        {
            double saldo = 0;
            ClienteCuenta c = BuscarCliente(cu);
            if(c!= null)
            {
                saldo = c.SaldoCuenta;
            }
            return saldo;
        }
        #endregion
    }
}
