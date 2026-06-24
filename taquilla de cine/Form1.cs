using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using taquilla_de_cine.Resources;

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
                boleto = new BoletoEstudiante(precioBase, txt_matricula.Text);
                
            }
            //Aqui Sonia
            else if (cbo_TipoBoleto.Text == "Adulto mayor")
            {
                boleto = new BoletoAdultoMayor(precioBase,txt_matricula.Text);

            }
            //Aqui Juan
            else if(cbo_TipoBoleto.Text == "General")
            {
                boleto = new BoletoGeneral(precioBase);
            }
            if (boleto != null)
            {
                float pagoFinal = boleto.calcularPagoFinal();
                lbl_total.Text = pagoFinal.ToString("C");   
                
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de boleto válido.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void LimpiarCajas()
        {
           txt_precio.Clear();
            txt_matricula.Clear();
            cbo_TipoBoleto.SelectedIndex = -1;
            txt_precio.Focus();
            lbl_total.Text = "";    
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }
    }
}
