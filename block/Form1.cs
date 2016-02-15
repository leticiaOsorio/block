using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace block
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string v;
            // Mostrar ventana
            openFileDialog1.ShowDialog();
            //leer eel  archivo seleccionado 
            System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);
            //pasa el texto en unaa variable
            v = file.ReadLine();
            //manda a mostrar el richtextbox
            richTextBox1.Text = v.ToString();

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mostrar elejemplo de  nombre del  archivo
            saveFileDialog1.FileName = "Sin titulo.txt";
            //guaardar un archivo
            var guarda = saveFileDialog1.ShowDialog();
            // condiocion para permitiri que se guarde
            if (guarda == DialogResult.OK)
            { 
            using (var savefile = new System.IO.StreamWriter(saveFileDialog1.FileName + ".txt"))
                {
                    savefile.WriteLine(richTextBox1.Text);
            
                 }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
