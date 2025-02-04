using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Mensaje", "Rotulo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
                MessageBox.Show("Has seleccionado YES");
            if (resultado == DialogResult.No)
                MessageBox.Show("Has seleccionado NO");
            if (resultado == DialogResult.Cancel)
                MessageBox.Show("Has seleccionado CANCEL");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
                MessageBox.Show("JAJAJAJJA te la comiste");
        }

        
    }
}
