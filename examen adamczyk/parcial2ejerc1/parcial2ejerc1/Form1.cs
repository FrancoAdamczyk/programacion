using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial2ejerc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(textBox1.Text);
            clima cl = clima.getInstance();
            cl.colocartemperatura(Convert.ToDouble(textBox1.Text));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clima cl = clima.getInstance();
            label1.Text = cl.obtenertemp();
        }
    }
}
