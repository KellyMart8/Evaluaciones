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
    public partial class MDI : Form
    {
        Form1 a = new Form1();
        Form2 b = new Form2();
        public MDI()
        {
            InitializeComponent();
        }

        private void solicitudPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a.MdiParent = this;
            a.Show();
        }

        private void depreciacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b.MdiParent = this;
            a.Show();
        }
    }
}
