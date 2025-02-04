using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            button4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string t = textBox1.Text;
            comboBox1.Items.Add(t);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = comboBox1.SelectedItem.ToString();
            MessageBox.Show(a);
            textBox1.Text = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button3.Visible = true;
        }

        
    }
}
