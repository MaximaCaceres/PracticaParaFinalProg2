namespace Final2deProg2_06._12
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCuit = new System.Windows.Forms.TextBox();
            this.btnAgregarSelec = new System.Windows.Forms.Button();
            this.btnVerSaldo = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbxkg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnElegir = new System.Windows.Forms.Button();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExClientes = new System.Windows.Forms.Button();
            this.btnExPedidos = new System.Windows.Forms.Button();
            this.btnIm = new System.Windows.Forms.Button();
            this.btnResumen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnPagar);
            this.groupBox1.Controls.Add(this.btnVerSaldo);
            this.groupBox1.Controls.Add(this.btnAgregarSelec);
            this.groupBox1.Controls.Add(this.tbxCuit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 383);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar/Agregar Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CUIT";
            // 
            // tbxCuit
            // 
            this.tbxCuit.Location = new System.Drawing.Point(53, 37);
            this.tbxCuit.Name = "tbxCuit";
            this.tbxCuit.Size = new System.Drawing.Size(181, 20);
            this.tbxCuit.TabIndex = 3;
            // 
            // btnAgregarSelec
            // 
            this.btnAgregarSelec.Location = new System.Drawing.Point(18, 87);
            this.btnAgregarSelec.Name = "btnAgregarSelec";
            this.btnAgregarSelec.Size = new System.Drawing.Size(116, 35);
            this.btnAgregarSelec.TabIndex = 4;
            this.btnAgregarSelec.Text = "Agregar/Seleccionar";
            this.btnAgregarSelec.UseVisualStyleBackColor = true;
            // 
            // btnVerSaldo
            // 
            this.btnVerSaldo.Location = new System.Drawing.Point(154, 87);
            this.btnVerSaldo.Name = "btnVerSaldo";
            this.btnVerSaldo.Size = new System.Drawing.Size(94, 35);
            this.btnVerSaldo.TabIndex = 5;
            this.btnVerSaldo.Text = "Ver Saldo";
            this.btnVerSaldo.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(265, 87);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(94, 35);
            this.btnPagar.TabIndex = 6;
            this.btnPagar.Text = "Realizar Pago";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btnAgregarP);
            this.groupBox2.Controls.Add(this.btnElegir);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbxkg);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(6, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 210);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Pedido";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cat",
            "BullDog",
            "Purina"});
            this.comboBox1.Location = new System.Drawing.Point(12, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // tbxkg
            // 
            this.tbxkg.Location = new System.Drawing.Point(81, 59);
            this.tbxkg.Name = "tbxkg";
            this.tbxkg.Size = new System.Drawing.Size(65, 20);
            this.tbxkg.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kg";
            // 
            // btnElegir
            // 
            this.btnElegir.Location = new System.Drawing.Point(73, 110);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(73, 35);
            this.btnElegir.TabIndex = 6;
            this.btnElegir.Text = "Elegir Producto";
            this.btnElegir.UseVisualStyleBackColor = true;
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Location = new System.Drawing.Point(73, 155);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(123, 35);
            this.btnAgregarP.TabIndex = 7;
            this.btnAgregarP.Text = "Agregar Pedido";
            this.btnAgregarP.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 43);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 147);
            this.textBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Productos Elegidos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnResumen);
            this.groupBox3.Controls.Add(this.btnIm);
            this.groupBox3.Controls.Add(this.btnExPedidos);
            this.groupBox3.Controls.Add(this.btnExClientes);
            this.groupBox3.Location = new System.Drawing.Point(480, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 383);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sistema";
            // 
            // btnExClientes
            // 
            this.btnExClientes.Location = new System.Drawing.Point(44, 37);
            this.btnExClientes.Name = "btnExClientes";
            this.btnExClientes.Size = new System.Drawing.Size(181, 35);
            this.btnExClientes.TabIndex = 6;
            this.btnExClientes.Text = "Exportar Cliente";
            this.btnExClientes.UseVisualStyleBackColor = true;
            // 
            // btnExPedidos
            // 
            this.btnExPedidos.Location = new System.Drawing.Point(44, 99);
            this.btnExPedidos.Name = "btnExPedidos";
            this.btnExPedidos.Size = new System.Drawing.Size(181, 38);
            this.btnExPedidos.TabIndex = 7;
            this.btnExPedidos.Text = "Exportar Pedidos";
            this.btnExPedidos.UseVisualStyleBackColor = true;
            // 
            // btnIm
            // 
            this.btnIm.Location = new System.Drawing.Point(44, 161);
            this.btnIm.Name = "btnIm";
            this.btnIm.Size = new System.Drawing.Size(181, 35);
            this.btnIm.TabIndex = 8;
            this.btnIm.Text = "Importar Pedidos";
            this.btnIm.UseVisualStyleBackColor = true;
            // 
            // btnResumen
            // 
            this.btnResumen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnResumen.Location = new System.Drawing.Point(44, 265);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(181, 35);
            this.btnResumen.TabIndex = 9;
            this.btnResumen.Text = "Resumen de Pedidos";
            this.btnResumen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 414);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnVerSaldo;
        private System.Windows.Forms.Button btnAgregarSelec;
        private System.Windows.Forms.TextBox tbxCuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.Button btnElegir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxkg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnIm;
        private System.Windows.Forms.Button btnExPedidos;
        private System.Windows.Forms.Button btnExClientes;
        public System.Windows.Forms.Button btnResumen;
    }
}

