namespace Final2deProg2_06._12
{
    partial class FormDePagos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbxMontoP = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese monto a pagar:";
            // 
            // tbxMontoP
            // 
            this.tbxMontoP.Location = new System.Drawing.Point(125, 33);
            this.tbxMontoP.Name = "tbxMontoP";
            this.tbxMontoP.Size = new System.Drawing.Size(100, 20);
            this.tbxMontoP.TabIndex = 1;
            // 
            // btnPagar
            // 
            this.btnPagar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPagar.Location = new System.Drawing.Point(41, 68);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(150, 31);
            this.btnPagar.TabIndex = 2;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // FormDePagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 114);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.tbxMontoP);
            this.Controls.Add(this.label1);
            this.Name = "FormDePagos";
            this.Text = "FormDePagos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbxMontoP;
        public System.Windows.Forms.Button btnPagar;
    }
}