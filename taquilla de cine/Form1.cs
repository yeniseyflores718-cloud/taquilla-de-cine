using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taquilla_de_cine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbo_TipoBoleto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_TipoBoleto.Text == "Estudiante")
            {
                lbl_extra.Text = "Matricula:";
                txt_matricula.Visible = true;
                lbl_extra.Visible = true;
            }
            else if (cbo_TipoBoleto.Text == "Adulto mayor")
            {
                lbl_extra.Text = "No. INAPAM:";
                txt_matricula.Visible = true;
                lbl_extra.Visible = true;
            }
            else
            {
                lbl_extra.Visible = false;
                txt_matricula.Visible = false;
            }
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            float precioBase = float.Parse(txt_precio.Text);
            boleto boleto= null;
            //Aqui trabajara Kevin
            if (cbo_TipoBoleto.Text == "Estudiante")
            {
                
            }
            //Aqui Sonia
            else if (cbo_TipoBoleto.Text == "Adulto mayor")
            {
               
            }
            //Aqui Juan
            else if(cbo_TipoBoleto.Text == "General")
            {
                
            }
            if (boleto != null)
            {
                float pagoFinal = boleto.calcularPagoFinal();
                MessageBox.Show("El pago final es: " + pagoFinal.ToString("C"));
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de boleto válido.");
            }
        }
    }
}
