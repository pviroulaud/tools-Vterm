using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HEX;

using System.IO;

namespace V_Term
{
    public partial class Form2 : Form
    {
        Form1 frm_MAIN;

        public Form2(Form1 Principal)
        {
            InitializeComponent();
            frm_MAIN = Principal;

        }
        public void CargarBuffers()
        {
            checkedListBox1.Items.Clear();
            for (int n = 0; n < frm_MAIN.BufferTX.Length; n++)
            {
                checkedListBox1.Items.Add("Buffer #" + (n+1).ToString());
                if (frm_MAIN.HabilitarBuffer[n] == true)
                {
                    checkedListBox1.SetItemChecked(n, true);
                }
            }
            checkedListBox1.SetSelected(0, true);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            CargarBuffers();
            AjustarTamaño();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ASCIIHEX_1.Titulo = checkedListBox1.SelectedItem.ToString();
            ASCIIHEX_1.LimpiarTodo();
            ASCIIHEX_1.AgregarBYTEs(frm_MAIN.BufferTX[checkedListBox1.SelectedIndex]);
        }



        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            frm_MAIN.HabilitarBuffer[e.Index] = Convert.ToBoolean(e.NewValue);
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ASCIIHEX_1.TeclaPresionada(e.KeyChar);
        }
        private void AjustarTamaño()
        {
            checkedListBox1.Top = 12;
            checkedListBox1.Left = 12;
            checkedListBox1.Width = (this.Width / 4) - 24;
            checkedListBox1.Height = this.Height - 42 - button1.Height;

            ASCIIHEX_1.Top = checkedListBox1.Top;
            ASCIIHEX_1.Left=checkedListBox1.Left+checkedListBox1.Width+12;
            ASCIIHEX_1.Width=(3*this.Width/4)-24;
            ASCIIHEX_1.Height = checkedListBox1.Height - button1.Height;
            
            button1.Top = ASCIIHEX_1.Top + ASCIIHEX_1.Height + 3;
            button1.Left = ASCIIHEX_1.Left + ASCIIHEX_1.Width - button1.Width;
        }
        private void ASCIIHEX_1_Leave(object sender, EventArgs e)
        {
            frm_MAIN.BufferTX[checkedListBox1.SelectedIndex] = ASCIIHEX_1.Valores;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_MAIN.BufferTX[checkedListBox1.SelectedIndex] = ASCIIHEX_1.Valores;
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            AjustarTamaño();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_MAIN.BufferTX[checkedListBox1.SelectedIndex] = ASCIIHEX_1.Valores;
            ASCIIHEX_1.LimpiarTodo();
            this.Visible = false;
        }

        private void cargarDesdeArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos binarios (*.HEX)|*.HEX|Todos los archivos (*.*)|*.*";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Archivos binarios (*.HEX)|*.HEX";
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            ASCIIHEX_1.GuardarArchivo(saveFileDialog1.FileName);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            ASCIIHEX_1.CargarArchivo(openFileDialog1.FileName);
        }

        private void limpiarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ASCIIHEX_1.LimpiarTodo();
        }
    }
}
