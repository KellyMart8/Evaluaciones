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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
         // val / vida util
         // 5, 20 , 12
        private void Form2_Load(object sender, EventArgs e)
        {
            txtDepre.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            mtValor.Text = "";
            txtDepre.Clear();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int vall, vidU;
            double depre;



        }
    }
}
