using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace V_Term
{
    public partial class Form_ConfRX : Form
    {
        Form1 frm_MAIN;

        public Form_ConfRX(Form1 Principal)
        {
            InitializeComponent();
            frm_MAIN = Principal;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                numericUpDown3.Enabled = true;
                numericUpDown4.Enabled = true;
            }
            else
            {
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_MAIN.TimeOut_Recepcion = (int)numericUpDown2.Value;
            frm_MAIN.Cant_De_Bytes_Que_Generan_Evento = (int)numericUpDown1.Value;
            frm_MAIN.Tiempo_TransmisionPeriodica = (int)numericUpDown4.Value;
            frm_MAIN.Buffer_A_Transmitir_periodicamente = (int)numericUpDown3.Value;

            frm_MAIN.TX_Automatica = checkBox1.Checked;
            frm_MAIN.TX_Periodica = checkBox2.Checked;
            frm_MAIN.TX_Condicional = checkBox3.Checked;

            frm_MAIN.Condicional_De_Recepcion = textBox1.Text;

            frm_MAIN.TX_Condicional_TRUE = checkBox4.Checked;
            frm_MAIN.TX_Condicional_FALSE = checkBox5.Checked;
            frm_MAIN.Buffer_A_Transmitir_Condicion_TRUE = (int)numericUpDown5.Value;
            frm_MAIN.Buffer_A_Transmitir_Condicion_FALSE = (int)numericUpDown6.Value;

            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button2_VisibleChanged(object sender, EventArgs e)
        {
            if (frm_MAIN != null)
            {
                if (frm_MAIN.PS != null)
                {
                    if (frm_MAIN.PS.IsOpen)
                    {
                        numericUpDown2.Enabled = false;
                        numericUpDown1.Enabled = false;
                    }
                    else
                    {
                        numericUpDown2.Enabled = true;
                        numericUpDown1.Enabled = true;
                    }
                }
                else
                {
                    numericUpDown2.Enabled = false;
                    numericUpDown1.Enabled = false;
                }
                numericUpDown2.Value = frm_MAIN.TimeOut_Recepcion;
                numericUpDown1.Value = frm_MAIN.PS.ReceivedBytesThreshold;
            }
        }

        private void Form_ConfRX_Load(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox1.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                button3.Enabled = true;
                numericUpDown5.Enabled = true;
                numericUpDown6.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                button3.Enabled = false;
                numericUpDown5.Enabled = false;
                numericUpDown6.Enabled = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }
            else
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button3.BackColor = Color.LightYellow;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if(frm_MAIN.Verificar_Sintaxis_Condicional(textBox1.Text))
            //{
            //    button3.BackColor = Color.LightGreen;
            //}
            //else
            //{
            //    button3.BackColor = Color.Red;
            //}
            //frm_MAIN.Crear_Archivo_Script(textBox1.Text, frm_MAIN.RutaYNombreDeArchivoDeCondicional);
            //if (frm_MAIN.Chequear_Archivo_Script(frm_MAIN.RutaYNombreDeArchivoDeCondicional))
            //{
            //    button3.BackColor = Color.LightGreen;
            //}
            //else
            //{
            //    button3.BackColor = Color.Red;
            //}
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox2.Enabled = true;
                if (FinLinea1.Checked) { frm_MAIN.Fin_De_Linea = "\n"; }
                if (FinLinea3.Checked) { frm_MAIN.Fin_De_Linea = "\t"; }
                if (FinLinea4.Checked) { frm_MAIN.Fin_De_Linea = ((char)(0x0A)).ToString(); }
                if (FinLinea5.Checked) { frm_MAIN.Fin_De_Linea = ((char)(0x0D)).ToString(); }
                if (FinLinea2.Checked) { frm_MAIN.Fin_De_Linea = textBox2.Text; }
            }
            else
            {
                groupBox2.Enabled = false;
                frm_MAIN.Fin_De_Linea = "NONE";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                frm_MAIN.Fin_De_Linea = "NONE";
                groupBox2.Enabled = false;
            }
        }

        private void FinLinea1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (FinLinea1.Checked) { frm_MAIN.Fin_De_Linea = "\n"; }
            if (FinLinea3.Checked) { frm_MAIN.Fin_De_Linea = "\t"; }
            if (FinLinea4.Checked) { frm_MAIN.Fin_De_Linea = ((char)(0x0A)).ToString(); }
            if (FinLinea5.Checked) { frm_MAIN.Fin_De_Linea = ((char)(0x0D)).ToString(); }
            if (FinLinea2.Checked) { frm_MAIN.Fin_De_Linea = textBox2.Text; }
            textBox2.Text = frm_MAIN.Fin_De_Linea;
        }
    }
}
