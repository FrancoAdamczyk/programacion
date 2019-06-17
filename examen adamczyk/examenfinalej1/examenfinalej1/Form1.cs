using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examenfinalej1
{  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            pedido a = new pedido(int.Parse(txtnpedido.Text), txttipopedido.Text, double.Parse(txtmonto.Text), txthorapedido.Text,txthoraentrega.Text);
            negocio neg = new negocio();
            neg.GetPedido1();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pedido a = new pedido(int.Parse(txtnpedido.Text), txttipopedido.Text, double.Parse(txtmonto.Text), txthorapedido.Text, txthoraentrega.Text);
            negocio neg = new negocio();
            neg.GetPedido2();

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
           
       
            
        }

        private void button4_Click(object sender, EventArgs e)
        {     

        }
    }
}


