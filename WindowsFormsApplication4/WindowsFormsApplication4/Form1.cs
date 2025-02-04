using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            of1.InitialDirectory = "C:\\";
            of1.ShowDialog();
            rt1.LoadFile(of1.FileName, RichTextBoxStreamType.PlainText);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sf1.ShowDialog();
            rt1.SaveFile(sf1.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 60000; j++) for (int k = 0; k < 600; k++) ;
                pb1.Value = i;
            }
            MessageBox.Show("DESPERTASTE");
        }
    }
}
