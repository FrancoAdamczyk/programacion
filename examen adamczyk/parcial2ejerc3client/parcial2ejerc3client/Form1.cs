using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial2ejerc3client
{
    public partial class Form1 : Form
    {

        string aux = "";
        const String rutaestado0 = "C:\\Users\\Estudiante\\programacionIII\\Ahorcado\\0.png";
        const String rutaestado1 = "C:\\Users\\Estudiante\\programacionIII\\Ahorcado\\1.png";
        const String rutaestado2 = "C:\\Users\\Estudiante\\programacionIII\\Ahorcado\\2.png";
        const String rutaestado3 = "C:\\Users\\Estudiante\\programacionIII\\Ahorcado\\3.png";
        const String rutaestado4 = "C:\\Users\\Estudiante\\programacionIII\\Ahorcado\\4.png";
        const String rutaestado5 = "C:\\Users\\Estudiante\\programacionIII\\Ahorcado\\5.png";
        const String rutaestado6 = "C:\\Users\\Estudiante\\programacionIII\\Ahorcado\\6.png";
        const String rutaestado7 = "C:\\Users\\Estudiante\\programacionIII\\Ahorcado\\7.png";
        

        String Solicitud = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void Renderizar(String mensaje)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            ahorcado.getInstancia().Iniciar();
        }

        private void txtLetra_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtPalabra_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResultado.Text = ahorcado.getInstancia().Buscar(txtLetra.Text[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
