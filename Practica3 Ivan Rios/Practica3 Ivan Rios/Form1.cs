using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3_Ivan_Rios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rt1.Visible = false;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            of1.InitialDirectory = "C:/Users/Alumno/Desktop";
            of1.ShowDialog();
            rt1.LoadFile(of1.FileName, RichTextBoxStreamType.PlainText);
            t1.Text = of1.FileName;
            rt1.Visible = true;
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sf1.ShowDialog();
            rt1.SaveFile(sf1.FileName);
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 60000; j++) for (int k = 0; k < 600; k++) ;
                pb1.Value = i;
            }
            MessageBox.Show("Archivo guardado");
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rt1.Text = null;
            rt1.Visible = true;
            t1.Text = null;
            pb1.Value = 0;
        }

        private void rt1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            fd1.ShowDialog();
            rt1.Font = fd1.Font;
        }

        private void a1_Click(object sender, EventArgs e)
        {
            of1.InitialDirectory = "C:/Users/Alumno/Desktop";
            of1.ShowDialog();
            rt1.LoadFile(of1.FileName, RichTextBoxStreamType.PlainText);
            t1.Text = of1.FileName;
            rt1.Visible = true;
        }

        private void g1_Click(object sender, EventArgs e)
        {
            sf1.ShowDialog();
            rt1.SaveFile(sf1.FileName);
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 60000; j++) for (int k = 0; k < 600; k++) ;
                pb1.Value = i;
            }
            MessageBox.Show("Archivo guardado");
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rt1.Visible = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rt1.SelectedText != "")
                Clipboard.SetText(rt1.SelectedText);
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                rt1.Text += Clipboard.GetText();
            }
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rt1.SelectAll();
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(!(rt1.Font.Bold))
            {
                rt1.Font = new Font(rt1.Font, FontStyle.Bold);
            }
            else
            {
                rt1.Font = new Font(rt1.Font, FontStyle.Regular);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (!(rt1.Font.Italic))
            {
                rt1.Font = new Font(rt1.Font, FontStyle.Italic);
            }
            else
            {
                rt1.Font = new Font(rt1.Font, FontStyle.Regular);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void t2_Click(object sender, EventArgs e)
        {
         
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            string texto = t2.Text;
            int indiceTexto = rt1.Find(texto, rt1.SelectionStart + rt1.SelectionLength, RichTextBoxFinds.None);
            //para buscar en todo texto encontrar
            rt1.Select(indiceTexto, texto.Length);
            rt1.SelectionColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = rt1.Text;
            string textoabuscar = "de";
            string textoremplazo = "para";
            texto = texto.Replace(textoabuscar, textoremplazo);
            rt1.Text = texto;
        }

        private void centradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rt1.SelectionAlignment > 0)
            {
                rt1.SelectionAlignment = HorizontalAlignment.Center;
            }
        }


    }
}
