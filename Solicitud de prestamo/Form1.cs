using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solicitud_de_prestamo
{

    // taza de interes de 18% anual
    //  monto requerido entre de 100 a 5000
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCuota.Enabled = false;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int ut, ing, egr, mr;

            ing = int.Parse(mtIng.Text);
            egr = int.Parse(mtEgr.Text);
            mr = int.Parse(mtMontoR.Text);


            if (ing > 500)
            {
                if (egr < ing)
                {
                    ut = ing - egr;
                }else
                {
                    MessageBox.Show("El egreso debe ser menor al ingreso");
                }
            }else
            {
                MessageBox.Show("EL ingreso debe ser mayor a 500");
            }

            
            string a = "Aceptado", b = "Denegado";

            //Monto requerido
            if (mr > 100 )
            {
                double couta = (mr * 0.18) / cboPlazo.SelectedIndex;
                double mSuficiente = (ing - egr) * 0.35;     // saber si es suficiente para cubrir con la cuota

                if (mSuficiente > couta) 
                {
                    couta = double.Parse(txtCuota.Text);
                    a = txtEstado.Text;
                }else
                {
                    b = txtEstado.Text;
                }
            }
            else
            {
                MessageBox.Show("El monto requerido debe ser mayor a 100 ");
            }

            //MONTO REUQERIDO * INTERES / PLAZO = CUOTA mensual
        }

        public void Limpiar()
        {
            txtName.Clear();
            txtCuota.Clear();
            mtEgr.Clear();
            mtIng.Clear();
            mtMontoR.Clear();
            cboPlazo.Text = "";
        }

        private void btnCLear_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
