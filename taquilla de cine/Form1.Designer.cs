namespace taquilla_de_cine
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_TipoBoleto = new System.Windows.Forms.ComboBox();
            this.lbl_extra = new System.Windows.Forms.Label();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btn_pagar);
            this.panel1.Controls.Add(this.lbl_total);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_precio);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_matricula);
            this.panel1.Controls.Add(this.lbl_extra);
            this.panel1.Controls.Add(this.cbo_TipoBoleto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(203, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 251);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de boleto:";
            // 
            // cbo_TipoBoleto
            // 
            this.cbo_TipoBoleto.FormattingEnabled = true;
            this.cbo_TipoBoleto.Items.AddRange(new object[] {
            "Estudiante",
            "Adulto mayor",
            "General"});
            this.cbo_TipoBoleto.Location = new System.Drawing.Point(172, 41);
            this.cbo_TipoBoleto.Name = "cbo_TipoBoleto";
            this.cbo_TipoBoleto.Size = new System.Drawing.Size(121, 21);
            this.cbo_TipoBoleto.TabIndex = 1;
            this.cbo_TipoBoleto.SelectedIndexChanged += new System.EventHandler(this.cbo_TipoBoleto_SelectedIndexChanged);
            // 
            // lbl_extra
            // 
            this.lbl_extra.AutoSize = true;
            this.lbl_extra.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_extra.Location = new System.Drawing.Point(70, 85);
            this.lbl_extra.Name = "lbl_extra";
            this.lbl_extra.Size = new System.Drawing.Size(85, 18);
            this.lbl_extra.TabIndex = 2;
            this.lbl_extra.Text = "Matricula:";
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(172, 85);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(100, 20);
            this.txt_matricula.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio base:";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(172, 125);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 20);
            this.txt_precio.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "TOTAL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 7;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(172, 168);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(47, 18);
            this.lbl_total.TabIndex = 8;
            this.lbl_total.Text = "$0.00";
            // 
            // btn_pagar
            // 
            this.btn_pagar.Location = new System.Drawing.Point(172, 200);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(75, 23);
            this.btn_pagar.TabIndex = 9;
            this.btn_pagar.Text = "pagar";
            this.btn_pagar.UseVisualStyleBackColor = true;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::taquilla_de_cine.Properties.Resources.WhatsApp_Image_2026_06_23_at_1_01_30_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_extra;
        private System.Windows.Forms.ComboBox cbo_TipoBoleto;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.Button btn_pagar;
    }
}

