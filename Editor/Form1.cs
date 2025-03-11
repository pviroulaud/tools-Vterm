using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Editor
{
    public partial class Form1 : Form
    {
        String Archivo = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AjustarTamaño();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AjustarTamaño();
        }
        private void AjustarTamaño()
        {
            this.Text = "Editor Hexadecimal - " + Archivo;

            heX_Editor1.Top = 12 + menuStrip1.Height;
            heX_Editor1.Left = 6;
            heX_Editor1.Width = this.Width - 24;
            heX_Editor1.Height = this.Height - (2*menuStrip1.Height) - 24;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            heX_Editor1.LimpiarTodo();
            Archivo = "";
            this.Text = "Editor Hexadecimal - " + Archivo;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            heX_Editor1.CargarArchivo(openFileDialog1.FileName);
            this.Text = "Editor Hexadecimal - " + openFileDialog1.FileName;
            Archivo = openFileDialog1.FileName;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            heX_Editor1.GuardarArchivo(saveFileDialog1.FileName);
            this.Text = "Editor Hexadecimal - " + saveFileDialog1.FileName;
            Archivo = saveFileDialog1.FileName;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Archivo != "")
            {
                heX_Editor1.GuardarArchivo(Archivo);
                this.Text = "Editor Hexadecimal - " + Archivo;
            }
            else
            {
                saveFileDialog1.FileName = Archivo;
                saveFileDialog1.ShowDialog();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            heX_Editor1.AgregarCHAR(e.KeyChar);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
