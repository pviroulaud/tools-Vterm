using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace V_Term
{
    public partial class Form_Configuracion : Form
    {
        Form1 MAIN;
        public Form_Configuracion(Form1 Creador)
        {
            InitializeComponent();
            MAIN = Creador;
        }

        private void Form_Configuracion_Load(object sender, EventArgs e)
        {
            CBox_Puertos.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if (CBox_Puertos.Items.Count > 0)
            {
                CBox_Puertos.SelectedIndex = 0;
            }
            CBox_Paridad.Items.Add(Parity.Even);
            CBox_Paridad.Items.Add(Parity.Mark);
            CBox_Paridad.Items.Add(Parity.None);
            CBox_Paridad.Items.Add(Parity.Odd);
            CBox_Paridad.Items.Add(Parity.Space);
            CBox_Paridad.SelectedItem = Parity.None;

            CBox_BitStop.Items.Add(StopBits.None);
            CBox_BitStop.Items.Add(StopBits.One);
            CBox_BitStop.Items.Add(StopBits.OnePointFive );
            CBox_BitStop.Items.Add(StopBits.Two);
            CBox_BitStop.Items.Add(StopBits.None);
            CBox_BitStop.SelectedItem = StopBits.One;

            CBox_Bits.Items.Add(5);
            CBox_Bits.Items.Add(6);
            CBox_Bits.Items.Add(7);
            CBox_Bits.Items.Add(8);
            CBox_Bits.SelectedItem = 8;

            CBox_Velocidad.Items.Add(1200);
            for (int n = 1; n< 5;n++)
            {
                CBox_Velocidad.SelectedIndex = n - 1;
                CBox_Velocidad.Items.Add(Convert.ToInt32(CBox_Velocidad.SelectedItem) * 2);
            }
            CBox_Velocidad.Items.Add(57600);
            CBox_Velocidad.Items.Add(115200);
            CBox_Velocidad.SelectedIndex = 1;
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CBox_Puertos.Items.Clear();
            CBox_Puertos.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if (CBox_Puertos.Items.Count > 0)
            {
                CBox_Puertos.SelectedIndex = 0;
            }

        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            MAIN.PS.Parity = (Parity)( CBox_Paridad.SelectedItem);
            MAIN.PS.PortName = CBox_Puertos.SelectedItem.ToString();
            MAIN.PS.DataBits = Convert.ToInt32( CBox_Bits.SelectedItem);
            MAIN.PS.StopBits = (StopBits)(CBox_BitStop.SelectedItem);
            MAIN.PS.BaudRate = Convert.ToInt32(CBox_Velocidad.SelectedItem);

            if (MAIN.PS.PortName.StartsWith("COM"))
            {
                MAIN.conectarToolStripMenuItem.Enabled = true;
            }
            this.Visible = false;
        }




    }
}
