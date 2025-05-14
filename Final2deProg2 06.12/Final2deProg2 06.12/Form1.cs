using Final2deProg2_06._12.Models;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Final2deProg2_06._12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarDatos();
        }
        GestionVentas gestion = new GestionVentas(56347548769, "Bananirou.Club");
        ClienteCuenta c = new ClienteCuenta();
        string path = Application.StartupPath + "gestion.dat";
        //que disponga de los datos de una empresa, 2 productos tipo Clásico, 2 productos tipo Premiun y una lista de 3 clientes con
        //topes de cuenta de 15000, 30000 y 70000 respectivamente.

        long cuitProceso;
        private void btnAgregarSelec_Click(object sender, EventArgs e)
        {
            long cuit = Convert.ToInt64(tbxCuit.Text);
            cuitProceso = cuit;
            try
            {
                ClienteCuenta cli = gestion.BuscarCliente(cuit);
                if (cli == null)
                {
                    c = new ClienteCuenta("Persona", cuit, 15000);//creo el cliente.
                    gestion.AgregarCliente(c);//lo agrega la gestion. 

                }
                else if (cli != null)
                {
                    MessageBox.Show("El cliente existe!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnVerSaldo_Click(object sender, EventArgs e)
        {
            double tot = gestion.VerSaldo(cuitProceso);
            tbxLista.Text += $"Saldo de cuenta: {tot:f2}\n";
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            bool pago = false;
            FormDePagos fp = new FormDePagos();
            double mont = 0;
            if (fp.ShowDialog() == DialogResult.OK)
            {
                mont = Convert.ToDouble(fp.tbxMontoP.Text);
                gestion.AgregarPago(cuitProceso, mont);
                c.AgregarPago(mont);
                pago = true;
            }
            if (pago == true)
            {
                MessageBox.Show($"Usted realizo un pago de {mont:f2}");
            }

        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            string producto = "";
            int prod = cbxPro.SelectedIndex;
            double kg = Convert.ToDouble(tbxkg.Text);
            switch (prod)
            {
                case 0:
                    {
                        producto = "Cat";
                    }
                    break;
                case 1:
                    { producto = "BullDog"; }
                    break;
                case 2:
                    { producto = "Purina"; }
                    break;
            }
            Producto p = new Clasico(2, "Clasico");//porque Producto es abstract.********************
            gestion.listaProductos.Add(p);
            p.Precio(kg);
            MessageBox.Show($"{producto} {kg:f2}kg fue seleccionado");
            tbxLista.AppendText(producto);//aca imprimo lo que cargo.

        }
        int i = 1;
        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            Pedido p = null;
            ClienteCuenta client = new ClienteCuenta();//porque tiene que quedar afuera del try.

            try
            {
                p = new Pedido(i++, gestion.listaProductos);//el primero es el numero de pedido.*************
                c.AgregarPedido(p);//cada pedido puede tener uno o mas productos, por eso le paso una lista de prod.

                if (client.SaldoCuenta <= client.Tope)
                {
                    ///////Cliente////////
                    int numP = p.Nro;
                    DateTime fechap = p.FechaHora;
                    string datClient = c.DatClient();
                    string datePClient = $@"{$"Pedido Nro: {numP}",10}
{$"Fecha: {fechap}",10}
{datClient,10}";
                    /////////Producto/////////
                    string r = p.VerResumen();
                    //////Final//////
                    ResumenPedido Rp = new ResumenPedido();//esta es una ventana modal
                    Rp.tbxResumen.Text += $"{datePClient}{Environment.NewLine}{r}";
                    Rp.ShowDialog();//porque muestro nada mas.****************************
                }
                else
                {
                    throw new ErrorCargaException();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnIm_Click(object sender, EventArgs e)//cargo un archivo de afuera.
        {
            OpenFileDialog Im = new OpenFileDialog();//open porque abro uno de afuera.
            Im.Filter = "ficheros csv|*.csv";
            if (Im.ShowDialog() == DialogResult.OK)
            {
                string path = Im.FileName;//saco el path.

                FileStream fs = null;//{
                StreamReader sr = null;
                Producto p;//} a estos los creo afuera del bloque try.

                try
                {
                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);//abro un flujo de datos.
                    sr = new StreamReader(fs);//es de tipo lectura porque leo algo de afuera para cargar.
                    //Le paso a la herramienta de "lectura".

                    string linea = sr.ReadLine();// leo  la primera antes porque es el titulo.

                    while (sr.EndOfStream == false)//mientras la herramienta de lectura no este en el final...
                    {
                        linea = sr.ReadLine();//leo la linea correspondiente.
                        string[] dat = linea.Split(';'); 
                        //Ejemplo://cantidad;nombre;precio;tipo
                        if (dat[3] == "P")//***************************** porque tenemos que ver si es C o P.
                        {
                            p = new Premiun();//creo un P
                            Premiun pr = p as Premiun;//casteo para asegurar.
                            pr.Leer(linea);
                            tbxLista.Text = pr.ToString();
                        }
                        else
                        {
                            p = new Clasico();
                            Clasico pr = p as Clasico;
                            pr.Leer(linea);
                            tbxLista.Text = pr.ToString();
                        }
                    }
                }
                catch (ErrorCargaException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();
                }
            }
        }

        private void btnExClientes_Click(object sender, EventArgs e)
        {
            SaveFileDialog Ex = new SaveFileDialog();//exportando, guardando.
            Ex.Filter = "ficheros csv |*.csv";
            if (Ex.ShowDialog() == DialogResult.OK)
            {
                string path = Ex.FileName;
                FileStream fs = null;
                StreamWriter sw = null;//cambia la herramienta. ahora es de escritura.
                ClienteCuenta c = null;
                try
                {
                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);//le digo que va a escribir.
                    sw = new StreamWriter(fs);
                    sw.WriteLine();//agrego titulo segun lo pedido del profe.

                    for (int i = 0; i < gestion.listaClientes.Count; i++)
                    {
                        c = gestion.listaClientes[i];//tomo a cada cliente
                        string s = c.Escribir();
                        sw.WriteLine(s);// y va escribiendo    
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (sw != null) sw.Close(); 
                    if (fs != null) fs.Close();
                }
            }
        }

        private void btnExPedidos_Click(object sender, EventArgs e)
        {
            SaveFileDialog Ex = new SaveFileDialog();//como guardo algo, entonces "Save".
            Ex.Filter = "ficheros csv |*.csv";
            if (Ex.ShowDialog() == DialogResult.OK)
            {
                string path = Ex.FileName;
                FileStream fs = null;
                StreamWriter sw = null;
                Pedido p = null;
                ClienteCuenta c = null;//cada client tiene una lista de pedidos.
                try
                {
                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    sw.WriteLine();
                    for (int i = 0; i < gestion.listaClientes.Count; i++)//especifico del problema***************
                    {
                        c = gestion.listaClientes[i];//porque necesito a cada uno de los clientes.****************

                        for (int j = 0; j < c.listaPedidos.Count; j++)//cada uno tiene una lista de pedidos
                        {                                              //entonces la recorremos.
                            p = new Pedido(j, gestion.listaProductos);
                            string s = p.Escribir();
                            sw.WriteLine(s);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        public void CargarDatos()
        {

            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                if (File.Exists(path))
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    bf = new BinaryFormatter();
                    gestion = bf.Deserialize(fs) as GestionVentas;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                bf = new BinaryFormatter();
                bf.Serialize(fs, gestion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }
    }
}
