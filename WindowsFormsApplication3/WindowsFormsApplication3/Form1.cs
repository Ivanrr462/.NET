using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("guardado");
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cerrado");
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fd.ShowDialog();
            t1.Font = fd.Font;
        }

        
    }
}
