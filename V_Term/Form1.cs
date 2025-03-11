using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Collections;

using System.IO;
//using IronPython.Hosting;
//using Microsoft.Scripting;
//using Microsoft.Scripting.Hosting;

namespace V_Term
{
    public partial class Form1 : Form
    {
        //private ScriptScope scope = null;
        //private ScriptEngine engine = Python.CreateEngine();
        private String Condicion;

        private Boolean STS_CD, STS_DTR, STS_DSR, STS_RTS, STS_CTS, STS_RI;
        private Form_Configuracion frm_CONFIG;
        private Form2 frm_TXBUFF;
        private AboutBox Acerca;
        private Form_ConfRX frm_RXCONF;

        private Boolean TransmisionAutomatica, TransmisionPeriodica, TransmisionCondicional, TransmisionSiTRUE, TransmisionSiFALSE;
        private int TiempoTransmisionPeriodica = 10;
        private int NumeroBufferTXAUTO_True, NumeroBufferTXAUTO_False, NumeroBufferTXAUTO_Periodica;

        public SerialPort PS;
        private int TO_RX ;
        private int ContaTO ;

        private Boolean cerrar = false;
        private Boolean quit = false;
        public Byte[][] BufferTX;
        public Boolean[] HabilitarBuffer;
        private int MaximaCantidadDeBuffers = 12;

        private Boolean SeSuperoElMaximoDeBytes = false;
        private int MaximoDeBytes = 2000000;

        DataGridViewCellStyle EstiloTX = new DataGridViewCellStyle();
        DataGridViewCellStyle EstiloRX = new DataGridViewCellStyle();
        DataGridViewCellStyle EstiloEspecial = new DataGridViewCellStyle();
        DataGridViewCellStyle EstiloNormal = new DataGridViewCellStyle();

        delegate void PresentadorDeDatos(Byte[] datos);

        public int TimeOut_Recepcion
        {
            get
            {
                if (TO_RX > 0)
                {
                    return (TO_RX / 2);
                }
                else
                {
                    //ContaTO = -1;
                    return (0);
                    
                }
            }
            set
            {
                if (value > 0)
                {
                    TO_RX = value * 2;
                    ContaTO = TO_RX;
                }
                else
                {
                    TO_RX = -1;
                    ContaTO = -1;
                }
            }
        }
        private int Ver =0 ; //0 = log
                            // 1 = tx | rx
                            // 2 = rx
                            // 3 = terminal

        String MenuPresionado = "";

        public string Fin_De_Linea
        {
            get
            {

                return PS.NewLine;
            }
            set
            {
                PS.NewLine = value;
            }
        }
        public String Condicional_De_Recepcion
        {
            get
            {
                return Condicion;
            }
            set
            {
                Condicion = value;
            }
        }
        public Boolean TX_Automatica
        {
            get
            {
                return TransmisionAutomatica;
            }
            set
            {
                TransmisionAutomatica = value;
            }
        }
        public Boolean TX_Periodica
        {
            get
            {
                return TransmisionPeriodica;
            }
            set
            {
                TransmisionPeriodica = value;
                if (TransmisionAutomatica && TransmisionPeriodica)
                {
                    TIM_TX_Auto.Enabled = true;
                }
                else
                {
                    TIM_TX_Auto.Enabled = false;
                }
            }
        }
        public Boolean TX_Condicional
        {
            get
            {
                return TransmisionCondicional;
            }
            set
            {
                TransmisionCondicional = value;
            }
        }
        public Boolean TX_Condicional_TRUE
        {
            get
            {
                return TransmisionSiTRUE;
            }
            set
            {
                TransmisionSiTRUE = value;
            }
        }
        public Boolean TX_Condicional_FALSE
        {
            get
            {
                return TransmisionSiFALSE;
            }
            set
            {
                TransmisionSiFALSE = value;
            }
        }
        public int Tiempo_TransmisionPeriodica
        {
            get
            {
                return TiempoTransmisionPeriodica;
            }
            set
            {
                TiempoTransmisionPeriodica = value;
                TIM_TX_Auto.Interval = TiempoTransmisionPeriodica;
            }
        }
        public int Buffer_A_Transmitir_periodicamente
        {
            get
            {
                return NumeroBufferTXAUTO_Periodica;
            }
            set
            {
                if ((value >= 0) && (value < 13))
                {
                    NumeroBufferTXAUTO_Periodica = value;
                }
            }
        }
        public int Buffer_A_Transmitir_Condicion_TRUE
        {
            get
            {
                return NumeroBufferTXAUTO_True;
            }
            set
            {
                if ((value >= 0) && (value < 13))
                {
                    NumeroBufferTXAUTO_True = value;
                }
            }
        }
        public int Buffer_A_Transmitir_Condicion_FALSE
        {
            get
            {
                return NumeroBufferTXAUTO_False;
            }
            set
            {
                if ((value >= 0) && (value < 13))
                {
                    NumeroBufferTXAUTO_False = value;
                }
            }
        }
        public int Cant_De_Bytes_Que_Generan_Evento
        {
            get
            {
                return PS.ReceivedBytesThreshold;
            }
            set
            {
                PS.ReceivedBytesThreshold = value;
            }
        }
        #region "Form"
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AjustarTamaño(Ver);
            frm_CONFIG = new Form_Configuracion(this);
            frm_RXCONF = new Form_ConfRX(this);

            PS = new SerialPort();
            

            conectarToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
            configuracionToolStripMenuItem.Enabled = true;

            BufferTX = new Byte[MaximaCantidadDeBuffers][];
            HabilitarBuffer = new Boolean[MaximaCantidadDeBuffers];

            EstiloTX.BackColor = Color.Red;
            EstiloRX.BackColor = Color.Green;
            EstiloEspecial.BackColor = Color.Yellow;
            EstiloNormal.BackColor = Color.White;

            

        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            AjustarTamaño(Ver);
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Ver == 3)
            {
                ASCIIHEX_2.TeclaPresionada(e.KeyChar);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            int tecla;
            if (PS != null)
            {
                if (PS.IsOpen)
                {
                    tecla = Convert.ToInt32(e.KeyData);
                    if ((tecla >= 112) && (tecla <= 123)) // si presiono F1 - F12
                    {
                        if (HabilitarBuffer[tecla - 112] == true)
                        {
                            if (BufferTX[tecla - 112].Length > 0)
                            {
                                Transmitir(BufferTX[tecla - 112]);
                            }
                        }
                        else
                        {
                            System.Media.SystemSounds.Beep.Play();
                        }
                    }
                    if (tecla==68) // si se presiono 'd' o 'D'
                    {
                        PS.DtrEnable = !PS.DtrEnable; // Toggle DTR
                    }
                    if (tecla == 82) // si se presiono 'r' o 'R'
                    {
                        PS.RtsEnable = !PS.RtsEnable;
                    }
                }
            }
        }


        #endregion

        #region "Menu"
        private void abrirVSPEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process PR1;
            try
            {
                PR1 = new System.Diagnostics.Process();
                PR1.StartInfo.FileName = @"C:\Program Files\Eterlogic.com\Virtual Serial Ports Emulator\" + "VSPEmulator.exe";
                PR1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo iniciar Virtual Serial Port Emulator.\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PR1 = null;
            }
        }
        private void bufferDeTransmisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_TXBUFF == null)
            {
                frm_TXBUFF = new Form2(this);
                frm_TXBUFF.Text = "Buffers de transmision";
            }
            frm_TXBUFF.Visible = true;
            frm_TXBUFF.CargarBuffers();
            frm_TXBUFF.Show();
            frm_TXBUFF.TopMost = true;
        }


        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PS != null)
            {
                if (!PS.IsOpen)
                {
                    frm_CONFIG.Visible = true;
                    conectarToolStripMenuItem.Enabled = false;
                    desconectarToolStripMenuItem.Enabled = false;
                }
            }
        }
        private void configuracionDeRecepcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PS != null)
            {
                frm_RXCONF.Visible = true;
            }
        }
        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PS != null)
            {
                if (!PS.IsOpen)
                {
                    try
                    {
                        PS.DataReceived += new SerialDataReceivedEventHandler(PS_DataReceived);
                        PS.PinChanged += new SerialPinChangedEventHandler(PS_PinChanged);

                        frm_CONFIG.CBox_Bits.SelectedItem = PS.DataBits;
                        frm_CONFIG.CBox_BitStop.SelectedItem = PS.StopBits;
                        frm_CONFIG.CBox_Paridad.SelectedItem = PS.Parity;
                        frm_CONFIG.CBox_Velocidad.SelectedItem = PS.BaudRate;

                        
                        //PS.ReceivedBytesThreshold = 1;
                        PS.Open();

                        conectarToolStripMenuItem.Enabled = false;
                        desconectarToolStripMenuItem.Enabled = true;
                        configuracionToolStripMenuItem.Enabled = false;
                        label8.BackColor = Color.Green;
                        label9.BackColor = Color.LightGray;
                        //byte[] arr = new Byte[3] { 0x41, 0xff, 0x32 };
                        //Transmitir(arr);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    
                }
            }
        }
        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PS != null)
            {
                if (PS.IsOpen)
                {
                    cerrar = true;
                    //PS.Close();
                    conectarToolStripMenuItem.Enabled = true;
                    desconectarToolStripMenuItem.Enabled = false;
                    configuracionToolStripMenuItem.Enabled = true;
                    label8.BackColor = Color.LightGray;
                    label9.BackColor = Color.Red ;
                }
            }
        }
        private void logDeComunicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Ver != 0)
            {
                Ver = 0;
                AjustarTamaño(Ver);
            }
        }

        private void transmisionRecepcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Ver != 2)
            {
                Ver = 2;
                AjustarTamaño(Ver);
                
            }
        }

        private void recepcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Ver != 1)
            {
                Ver = 1;
                AjustarTamaño(Ver);
                
            }
        }

        private void terminalTxRxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Ver != 3)
            {
                Ver = 3;
                AjustarTamaño(Ver);
            }
        }
        #endregion

        #region "puerto serie"
        void PS_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            
        }

        private void PresentaDatosRX(Byte[] Data)
        {
            if (this.InvokeRequired)
            {
                PresentadorDeDatos P = new PresentadorDeDatos(PresentaDatosRX);
                this.Invoke(P, new object[] { Data });
            }
            else
            {
                led2.Color_LED = ControlesVARIOS.LED.ControlLED_Colores.Verde;
                ASCIIHEX_1.AgregarBYTEs(Data);
                
                if (Ver == 3)
                {
                    Terminal.AgregarBYTEs(Data);
                }

                if (TransmisionAutomatica && TransmisionCondicional)
                {
                    //if (Verificar_Sintaxis_Condicional(Condicion))
                    //{
                    //    if (Evaluar_Condicional(Crear_Sentencia_Condicional(Condicion,Data)))
                    //    {
                    //        // si la condicion resulto TRUE
                    //        if (TransmisionSiTRUE)
                    //        {
                    //            Transmitir(BufferTX[NumeroBufferTXAUTO_True - 1]);
                    //        }
                    //    }
                    //    else
                    //    {
                    //        // si la condicion resulto FALSE
                    //        if (TransmisionSiFALSE)
                    //        {
                    //            Transmitir(BufferTX[NumeroBufferTXAUTO_False - 1]);
                    //        }

                    //    }
                    //}
                }
                AgregarLog("127.0.0.1", PS.PortName, "RX", Data.Length, Data, false);
            }
        }
        void PS_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Byte[] Buff;
            if (PS.NewLine!="NONE")
            { 
                if (PS.ReceivedBytesThreshold == 1)
                {
                    Buff = new Byte[PS.BytesToRead];
                }
                else
                {
                    Buff = new Byte[PS.ReceivedBytesThreshold];
                }
            }
            else
            {
                String str = PS.ReadLine();
                Buff = new Byte[str.Length];
                Buff = Encoding.ASCII.GetBytes(str);
            }
            if ((Buff.Length > 0)&&(cerrar != true ))
            {
                PS.Read(Buff, 0, Buff.Length);
                ContaTO = TO_RX;
                PresentaDatosRX(Buff);
                
            }
        }
        private void Transmitir(Byte[] Buffer)
        {
            led1.Color_LED = ControlesVARIOS.LED.ControlLED_Colores.Rojo;
            PS.Write(Buffer, 0, Buffer.Length);
            ASCIIHEX_2.AgregarBYTEs(Buffer);
            Terminal.AgregarBYTEs(Buffer);
            if (Ver == 0)
            {
                AgregarLog("127.0.0.1", PS.PortName, "TX", Buffer.Length, Buffer, true);
                
            }
            else
            {
                
                AgregarLog("127.0.0.1", PS.PortName, "TX", Buffer.Length, Buffer, false);
            }
        }
        #endregion

        #region "Funciones"
        private void AjustarTamaño(int como)
        {

            this.Text = "TERM V (" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() + "." +
                                     System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString() + ")";
            dataGridView1.Width = this.Width - 44;
            dataGridView1.Height = this.Height / 3;

            dataGridView1.Columns[0].Width = dataGridView1.Width / 8;
            dataGridView1.Columns[1].Width = dataGridView1.Width / 8;
            dataGridView1.Columns[2].Width = dataGridView1.Width / 8;
            dataGridView1.Columns[3].Width = dataGridView1.Width / 8;
            dataGridView1.Columns[4].Width = dataGridView1.Width / 16;
            dataGridView1.Columns[5].Width = dataGridView1.Width / 8;
            dataGridView1.Columns[6].Width = dataGridView1.Width - (dataGridView1.Width / 16) - (5 * dataGridView1.Width / 8) - 23;

            HEXEDIT_LOG.Edicion_Habilitada = false;
            ASCIIHEX_1.Edicion_Habilitada = false;
            ASCIIHEX_2.Edicion_Habilitada = false;

            HEXEDIT_LOG.Top = dataGridView1.Top + dataGridView1.Height + 10;
            HEXEDIT_LOG.Left = dataGridView1.Left;
            HEXEDIT_LOG.Width = dataGridView1.Width;
            HEXEDIT_LOG.Height = dataGridView1.Height - panel1.Height;

            ASCIIHEX_1.Top = dataGridView1.Top + dataGridView1.Height + 10;
            ASCIIHEX_1.Left = dataGridView1.Left;
            ASCIIHEX_1.Width = dataGridView1.Width;
            ASCIIHEX_1.Height = dataGridView1.Height - panel1.Height;

            HEXEDIT_LOG.Titulo = "REGISTRO SELECTADO";
            ASCIIHEX_1.Titulo = "-RECEPCION-";
            ASCIIHEX_2.Titulo = "-TRANSMISION-";

            Terminal.VER = HEX.HEX_Editor.Vistas.ASCII;
            Terminal.Titulo = "TERMINAL ASCII";

            if (como == 0)
            {
                dataGridView1.Visible = true;
                HEXEDIT_LOG.Visible = true;
                ASCIIHEX_1.Visible = false;
                ASCIIHEX_2.Visible = false;
                Terminal.Visible = false;

                HEXEDIT_LOG.Top = dataGridView1.Top + dataGridView1.Height + 10;
                HEXEDIT_LOG.Left = dataGridView1.Left;
                HEXEDIT_LOG.Width = dataGridView1.Width;
                HEXEDIT_LOG.Height = this.Height - dataGridView1.Height - panel1.Height - 100;
                panel1.Left = 30;
                panel1.Top = HEXEDIT_LOG.Top + HEXEDIT_LOG.Height;
            }
            if (como == 1)
            {
                dataGridView1.Visible = false;
                HEXEDIT_LOG.Visible = false;
                ASCIIHEX_2.Visible = false;
                Terminal.Visible = false;

                ASCIIHEX_1.Visible = true;
                ASCIIHEX_1.Top = dataGridView1.Top;
                ASCIIHEX_1.Height = this.Height - 70 - panel1.Height;
                panel1.Left = 30;
                panel1.Top = ASCIIHEX_1.Top + ASCIIHEX_1.Height;
            }
            if (como == 2)
            {
                dataGridView1.Visible = false;
                ASCIIHEX_2.Visible = true;
                ASCIIHEX_1.Visible = true;
                HEXEDIT_LOG.Visible = false;
                Terminal.Visible = false;

                ASCIIHEX_2.Top = dataGridView1.Top;
                ASCIIHEX_2.Left = dataGridView1.Left;
                ASCIIHEX_2.Width = dataGridView1.Width / 2;
                ASCIIHEX_2.Height = this.Height - 70 - panel1.Height;
                ASCIIHEX_1.Top = dataGridView1.Top;
                ASCIIHEX_1.Left = ASCIIHEX_2.Left + ASCIIHEX_2.Width + 5;
                ASCIIHEX_1.Width = dataGridView1.Width / 2;
                ASCIIHEX_1.Height = this.Height - 70 - panel1.Height;
               
                panel1.Left = 30;
                panel1.Top = ASCIIHEX_1.Top + ASCIIHEX_1.Height;
            }
            if (como == 3)
            {
                dataGridView1.Visible = false;
                ASCIIHEX_2.Visible = false ;
                ASCIIHEX_1.Visible = false;
                HEXEDIT_LOG.Visible = false;
                Terminal.Visible = true;

                
                Terminal.Top = dataGridView1.Top;
                Terminal.Left = dataGridView1.Left;
                Terminal.Width = dataGridView1.Width;
                Terminal.Height = this.Height - 70 - panel1.Height ;

                panel1.Left = 30;
                panel1.Top = Terminal.Top + Terminal.Height;


            }
            label8.BackColor = Color.LightGray;
            label9.BackColor = Color.Red;
            if (PS != null)
            {
                if (PS.IsOpen)
                {
                    label8.BackColor = Color.Green;
                    label9.BackColor = Color.LightGray;
                }
            }

        }

        private void AgregarLog(String IP,String Puerto,String TXRX,int CBytes,Byte[] valores,Boolean AutoselectRow)
        {
            int Nfila;
            string HEX;

            Nfila=dataGridView1.Rows.AddCopy(0);
            DataGridViewRow Fila = dataGridView1.Rows[Nfila];

            Fila.Cells[0].Value = DateTime.Today.ToShortDateString();
            Fila.Cells[1].Value = DateTime.Now.ToShortTimeString();
            Fila.Cells[2].Value = IP;
            Fila.Cells[3].Value = Puerto;
            Fila.Cells[4].Value = TXRX;
            Fila.Cells[5].Value = CBytes.ToString();
            for (int n = 0; n < valores.Length-1; n++)
            {
                
                HEX = Convert.ToString(valores[n], 16);
                if (HEX.Length == 1) { HEX = "0" + HEX; }
                HEX = HEX.ToUpper();

                Fila.Cells[6].Value = Fila.Cells[6].Value + HEX + "-";
            }
            HEX = Convert.ToString(valores[valores.Length-1], 16);
            if (HEX.Length == 1) { HEX = "0" + HEX; }
            HEX = HEX.ToUpper();

            Fila.Cells[6].Value = Fila.Cells[6].Value + HEX;
            for (int n = 0; n < Fila.Cells.Count; n++)
            {
                if (TXRX == "TX")
                {
                    Fila.Cells[n].Style = EstiloTX;
                }
                else
                {
                    if (TXRX == "RX")
                    {
                        Fila.Cells[n].Style = EstiloRX;
                    }
                    else
                    {
                        if (TXRX == "")
                        {
                            Fila.Cells[n].Style = EstiloNormal;
                        }
                        else
                        {
                            Fila.Cells[n].Style = EstiloEspecial;
                        }
                    }
                }
            }
            if (AutoselectRow)
            {
                dataGridView1.Rows[Nfila].Selected = true;
            }
        }
 
        private void MostrarDatosLog()
        {
            Byte[] valores;
            String[] vstrings;
            char[] sep = new char[1] { '-' };
            if (Ver == 0)
            {
                HEXEDIT_LOG.LimpiarTodo();
                if (dataGridView1.SelectedRows[0].Cells[5].Value != null)
                {
                    valores = new Byte[Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[5].Value)];
                    vstrings = dataGridView1.SelectedRows[0].Cells[6].Value.ToString().Split(sep);
                    for (int n = 0; n < vstrings.Length; n++)
                    {
                        valores[n] = Convert.ToByte(vstrings[n], 16);
                    }
                    HEXEDIT_LOG.AgregarBYTEs(valores);
                }
            }
        }

        private Boolean  CargarSesion(String Ruta_Y_Nombre_Del_Archivo)
        {
            Boolean ret = true;
            StreamReader Lec = new StreamReader(Ruta_Y_Nombre_Del_Archivo);
            String tmp;
            Byte[] vals;
            string[] vtmp;
            int b;

            try
            {
                Lec.ReadLine();
                tmp = Lec.ReadLine();
                if (tmp == "Configuracion:")
                {
                    PS.PortName = Lec.ReadLine();
                    PS.BaudRate = Convert.ToInt32(Lec.ReadLine());
                    PS.DataBits = Convert.ToInt32(Lec.ReadLine());
                    PS.Parity = (Parity)(Convert.ToInt32(Lec.ReadLine()));
                    PS.StopBits = (StopBits)(Convert.ToInt32(Lec.ReadLine()));
                    PS.ReceivedBytesThreshold = Convert.ToInt32(Lec.ReadLine());
                }
                else
                {
                    ret = false;
                }
                tmp = Lec.ReadLine();
                if (tmp == "LOG:")
                {
                    tmp = Lec.ReadLine();
                    while (tmp != "Bytes Transmitidos:")
                    {
                        
                        vtmp = tmp.Split(new char[] { '|' });
                        vals = new Byte[vtmp[5].Length];
                        for (int n = 0; n < vtmp[5].Length; n++)
                        {
                            vals[n] = Convert.ToByte(Convert.ToChar(vtmp[4].Substring(n, 1)));

                        }
                        AgregarLog(vtmp[2], vtmp[3], vtmp[4], Convert.ToInt32(vtmp[5].Length), vals, false);
                        tmp = Lec.ReadLine();
                    }
                }
                else
                {
                    ret = false;
                }    
                if (tmp == "Bytes Transmitidos:")
                {
                    tmp = Lec.ReadLine();
                    while (tmp != "Bytes Recibidos:")
                    {
                        vtmp=tmp.Split(new char[]{'-'},StringSplitOptions.RemoveEmptyEntries );
                        for (int n = 0; n < vtmp.Length; n++)
                        {
                            ASCIIHEX_2.AgregarBYTE(Convert.ToByte(vtmp[n],16));
                        }
                        tmp = Lec.ReadLine();
                    }
                }
                else
                {
                    ret = false;
                }
                if (tmp == "Bytes Recibidos:")
                {
                    tmp = Lec.ReadLine();
                    while (tmp != "Bytes Terminal:")
                    {
                        vtmp = tmp.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                        for (int n = 0; n < vtmp.Length; n++)
                        {
                            ASCIIHEX_1.AgregarBYTE(Convert.ToByte(vtmp[n],16));
                        }
                        tmp = Lec.ReadLine();
                    }
                }
                else
                {
                    ret = false;
                }
                if (tmp == "Bytes Terminal:")
                {
                    tmp = Lec.ReadLine();
                    while (tmp != "Buffers de transmision:")
                    {
                        vtmp = tmp.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                        for (int n = 0; n < vtmp.Length; n++)
                        {
                            Terminal.AgregarBYTE(Convert.ToByte(vtmp[n], 16));
                        }
                        tmp = Lec.ReadLine();
                    }
                }
                else
                {
                    ret = false;
                }
                if (tmp == "Buffers de transmision:")
                {
                    tmp = Lec.ReadLine();
                    while (tmp != "Fin Buffers de transmision:")
                    {
                        if (tmp.StartsWith("Buffer Numero: "))
                        {
                            b = Convert.ToInt32(tmp.Remove(0, 15));
                            tmp = Lec.ReadLine();
                            vtmp = tmp.Split(new char[] { '-' },StringSplitOptions.RemoveEmptyEntries);

                            if (vtmp.Length > 0)
                            {
                                BufferTX[b] = new Byte[vtmp.Length];
                                for (int n = 0; n < vtmp.Length; n++)
                                {
                                    BufferTX[b][n] = Convert.ToByte(vtmp[n], 16);
                                }
                            }
                        
                        }
                        tmp = Lec.ReadLine();
                    }
                }
                else
                {
                    ret = false;
                }
            }
            catch (Exception ex)
            {
                ret = false;
            }
            return ret;
        }

        private void GuardarSesion(String Ruta_Y_Nombre_Del_Archivo)
        {
            StreamWriter Escr = new StreamWriter(Ruta_Y_Nombre_Del_Archivo);
            string[] tmp;
            string valorSel = "";
            int f,c,b;
            Escr.WriteLine("Sesion: " + Ruta_Y_Nombre_Del_Archivo.Remove(0, Ruta_Y_Nombre_Del_Archivo.LastIndexOf(@"\")));
            Escr.WriteLine("Configuracion:");
            Escr.WriteLine(PS.PortName);
            Escr.WriteLine(PS.BaudRate.ToString());
            Escr.WriteLine(PS.DataBits.ToString());
            Escr.WriteLine(Convert.ToInt32(PS.Parity));
            Escr.WriteLine(Convert.ToInt32(PS.StopBits));
            Escr.WriteLine(PS.ReceivedBytesThreshold.ToString());
            /************************************************************************************/
            Escr.WriteLine("LOG:");
            for ( f=0;f<dataGridView1.Rows.Count-1;f++)
            {
                for ( c = 0; c < dataGridView1.Columns.Count-2; c++)
                {
                    Escr.Write(dataGridView1.Rows[f].Cells[c].Value.ToString() + "|");
                }
                tmp = dataGridView1.Rows[f].Cells[c].Value.ToString().Split(new char[] { '-' });
                for (b = 0; b < tmp.Length; b++)
                {
                    Escr.Write(Convert.ToChar(Convert.ToByte(tmp[b], 16)));
                }
                Escr.WriteLine();
                
            }
            /************************************************************************************/
            Escr.WriteLine("Bytes Transmitidos:");
            for (b = 0; b < ASCIIHEX_2.Valores.Length; b++)
            {
                valorSel = Convert.ToString(ASCIIHEX_2.Valores[b], 16).ToUpper();
                if (valorSel.Length == 1) { valorSel = "0" + valorSel; }
                Escr.Write(valorSel + "-");
            }
            Escr.WriteLine();
            /************************************************************************************/
            Escr.WriteLine("Bytes Recibidos:");
            for (b = 0; b < ASCIIHEX_1.Valores.Length; b++)
            {
                valorSel = Convert.ToString(ASCIIHEX_1.Valores[b], 16).ToUpper();
                if (valorSel.Length == 1) { valorSel = "0" + valorSel; }
                Escr.Write(valorSel + "-");
            }
            Escr.WriteLine();
            /************************************************************************************/
            Escr.WriteLine("Bytes Terminal:");
            for (b = 0; b < Terminal.Valores.Length; b++)
            {
                valorSel = Convert.ToString(Terminal.Valores[b], 16).ToUpper();
                if (valorSel.Length == 1) { valorSel = "0" + valorSel; }
                Escr.Write(valorSel + "-");
            }
            Escr.WriteLine();
            /************************************************************************************/
            Escr.WriteLine("Buffers de transmision:");
            for (f = 0; f < BufferTX.Length; f++)
            {
                Escr.WriteLine("Buffer Numero: " + f.ToString());
                if (BufferTX[f] != null)
                {
                    for (b = 0; b < BufferTX[f].Length; b++)
                    {
                        valorSel = Convert.ToString(BufferTX[f][b], 16).ToUpper();
                        if (valorSel.Length == 1) { valorSel = "0" + valorSel; }
                        Escr.Write(valorSel+"-");
                    }
                }
                Escr.WriteLine();
            }
            Escr.WriteLine("Fin Buffers de transmision:");
            Escr.Close();
        }

        private void GuardarLOG(String Ruta_Y_Nombre_Del_Archivo)
        {
            StreamWriter Escr = new StreamWriter(Ruta_Y_Nombre_Del_Archivo);
            string[] tmp;
            int f, c, b;
            Escr.WriteLine("Sesion: " + Ruta_Y_Nombre_Del_Archivo.Remove(0, Ruta_Y_Nombre_Del_Archivo.LastIndexOf(@"\")));
            /************************************************************************************/
            Escr.WriteLine("LOG:");
            for (f = 0; f < dataGridView1.Rows.Count - 1; f++)
            {
                for (c = 0; c < dataGridView1.Columns.Count - 2; c++)
                {
                    Escr.Write(dataGridView1.Rows[f].Cells[c].Value.ToString() + "|");
                }
                tmp = dataGridView1.Rows[f].Cells[c].Value.ToString().Split(new char[] { '-' });
                for (b = 0; b < tmp.Length; b++)
                {
                    Escr.Write(Convert.ToChar(Convert.ToByte(tmp[b], 16)));
                }
                Escr.WriteLine();
            }
        }

        private void GuardarBuffersDeTX(String Ruta_Y_Nombre_Del_Archivo)
        {
            int n = 0;
            int b = 0;
            System.IO.StreamWriter Escr;
            string extension= Ruta_Y_Nombre_Del_Archivo.Remove(0,Ruta_Y_Nombre_Del_Archivo.LastIndexOf("."));
            string nombre = Ruta_Y_Nombre_Del_Archivo.Remove(0, Ruta_Y_Nombre_Del_Archivo.LastIndexOf(@"\")+1);
            
            string ruta = Ruta_Y_Nombre_Del_Archivo.Replace(nombre,"");
            nombre = nombre.Replace(extension, "");
            extension = extension.Replace(".", "");
            
            for (n = 0; n < BufferTX.Length; n++)
            {
                if (BufferTX[n] != null)
                {
                    Escr = new System.IO.StreamWriter(ruta+nombre+ (n+1).ToString()+ "." +extension);
                    for (b = 0; b < BufferTX[n].Length; b++)
                    {
                        Escr.Write(Convert.ToChar(BufferTX[n][b]));
                    }
                    Escr.Close();
                    Escr = null;
                }
                
            }
            Escr = null;
        }
        
        #endregion

        #region "Controles del Form"
        private void rtc_Tick(object sender, EventArgs e)
        {
            if (ContaTO > 0) { ContaTO--; }
            if (PS != null)
            {
                if (PS.IsOpen)
                {
                    if (cerrar)
                    {
                        cerrar = false;
                        PS.Close();                     
                    }
                    else
                    {
                        //if ((ASCIIHEX_1.CantidadDeBytes > MaximoDeBytes) && (SeSuperoElMaximoDeBytes))
                        //{
                        //    SeSuperoElMaximoDeBytes = true;
                        //    DialogResult res = MessageBox.Show("Actualmente se recibieron " + ASCIIHEX_1.CantidadDeBytes + " Bytes\n" + "¿Desea eliminar los bytes mas antiguos?", "Advertecia", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        //    if (res == System.Windows.Forms.DialogResult.Yes)
                        //    {
                        //        ASCIIHEX_1.Limpiar(1000000);
                        //        MaximoDeBytes = 2000000;
                        //        SeSuperoElMaximoDeBytes = false;
                        //    }
                        //    else
                        //    {
                        //        MaximoDeBytes = MaximoDeBytes + 2000000;
                                
                        //    }
                        //}
                        //if (ASCIIHEX_1.CantidadDeBytes > (Int32.MaxValue - 1000))
                        //{
                        //    MaximoDeBytes = 2000000;
                        //    SeSuperoElMaximoDeBytes = false;
                        //    ASCIIHEX_1.Limpiar(2000000);
                        //}
                        if (ContaTO == 1)
                        {
                            ContaTO = TO_RX;
                            AgregarLog("127.0.0.1", PS.PortName, "TO_RX", 0,new Byte[1] {0x00}, false);
                        }
                        if (led1.Color_LED == ControlesVARIOS.LED.ControlLED_Colores.Rojo)
                        {
                            led1.Color_LED = ControlesVARIOS.LED.ControlLED_Colores.Apagado;
                        }
                        if (led2.Color_LED == ControlesVARIOS.LED.ControlLED_Colores.Verde)
                        {
                            led2.Color_LED = ControlesVARIOS.LED.ControlLED_Colores.Apagado;
                        }
                        if (PS.DtrEnable)
                        {
                            led3.Color_LED = ControlesVARIOS.LED.ControlLED_Colores.Rojo;
                        }
                        else
                        {
                            led3.Color_LED = ControlesVARIOS.LED.ControlLED_Colores.Apagado;
                        }
                        if (PS.DsrHolding)
                        {
                            led4.Color_LED = ControlesVARIOS.LED.ControlLED_Colores.Verde;
                        }
                        else
                        {
                            led4.Color_LED = ControlesVARIOS.LED.ControlLED_Colores.Apagado;
                        }
                        if (PS.RtsEnable)
                        {
                            led5.Color_LED = ControlesVARIOS.LED.ControlLED_Colores.Rojo;
                        }
                        else
                        {
                            led5.Color_LED = ControlesVARIOS.LED.ControlLED_Colores.Apagado;
                        }
                        if (PS.CtsHolding)
                        {
                            led6.Color_LED = ControlesVARIOS.LED.ControlLED_Colores.Verde;
                        }
                        else
                        {
                            led6.Color_LED = ControlesVARIOS.LED.ControlLED_Colores.Apagado;
                        }
                        if (PS.CDHolding)
                        {
                            led7.Color_LED = ControlesVARIOS.LED.ControlLED_Colores.Verde;
                        }
                        else
                        {
                            led7.Color_LED = ControlesVARIOS.LED.ControlLED_Colores.Apagado;
                        }
                    }
                }
            }
            if (quit)
            {
                cerrar = true;
                if (PS != null)
                {
                    if (PS.IsOpen)
                    {
                        PS.Close();
                    }
                    PS = null;
                }
                
                this.Close();
            }
        }

        private void label3_DoubleClick(object sender, EventArgs e)
        {
            if (PS != null)
            {
                if (PS.IsOpen)
                {
                    PS.DtrEnable = !PS.DtrEnable;
                }
            }
        }

        private void label5_DoubleClick(object sender, EventArgs e)
        {
            if (PS != null)
            {
                if (PS.IsOpen)
                {
                    PS.RtsEnable = !PS.RtsEnable;
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            MostrarDatosLog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarDatosLog();
        }

        private void vTERMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acerca = new AboutBox();
            Acerca.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void guardarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPresionado = "Guardar Sesion";
            saveFileDialog1.Filter = "Sesiones guardadas (*.SNSN)|*.snsn";
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
        }


        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            switch (MenuPresionado)
            {
                case "Guardar Sesion":
                    GuardarSesion(saveFileDialog1.FileName);
                    break;
                case "Guardar LOG":
                    GuardarLOG(saveFileDialog1.FileName);
                    break;
                case "Guardar Byte TX":
                    ASCIIHEX_2.GuardarArchivo(saveFileDialog1.FileName);
                    break;
                case "Guardar Byte RX":
                    ASCIIHEX_1.GuardarArchivo(saveFileDialog1.FileName);
                    break;
                case "Guardar Terminal":
                    Terminal.GuardarArchivo(saveFileDialog1.FileName);
                    break;
                case "Guardar Buffers de Transmision":
                    GuardarBuffersDeTX(saveFileDialog1.FileName);
                    break;
            }

            MenuPresionado = "";
        }

        private void abrirSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPresionado = "Abrir Sesion";
            openFileDialog1.Filter = "Sesiones guardadas (*.SNSN)|*.snsn";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            CargarSesion(openFileDialog1.FileName);
        }

        private void logDeEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPresionado = "Guardar LOG";
            saveFileDialog1.Filter = "LOGs guardados (*.LOG)|*.log";
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MenuPresionado = "Guardar Byte TX";
            saveFileDialog1.Filter = "Archivo binario de Bytes Transmitidos (*.HEX)|*.hex";
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
        }

        private void bytesRecibidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPresionado = "Guardar Byte RX";
            saveFileDialog1.Filter = "Archivo binario de Bytes Recibidos (*.HEX)|*.hex";
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MenuPresionado = "Guardar Terminal";
            saveFileDialog1.Filter = "Archivo binario (*.HEX)|*.hex";
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
        }

        private void buffersDeTransmisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPresionado = "Guardar Buffers de Transmision";
            saveFileDialog1.Filter = "Archivos binarios de Buffers de Transmision (*.HEX)|*.hex";
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PS != null)
            {
                if (PS.IsOpen)
                {
                    PS.ReadExisting();
                    cerrar = true;
                    
                }
            }
            quit = true;

        }

        private void abrirEditorHexadecimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process PR1 = new System.Diagnostics.Process();
            PR1.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "Editor.exe";
            PR1.Start();
        }
        #endregion

        //#region "Interprete Phyton"
        //public Boolean Chequear_Archivo_Script(String RutaYNombre)
        //{
        //    Boolean ret = true;
        //    try
        //    {
        //        ScriptSource source = engine.CreateScriptSourceFromFile(RutaYNombre);
        //        source.Compile();
        //        source = null;
        //    }
        //    catch (Exception)
        //    {

        //        ret = false;
        //    }

        //    return ret;
        //}
        //private Boolean Ejecutar_Archivo_Script(string RutaYNombre)
        //{
        //    Boolean ret = false;
        //    try
        //    {
        //        engine.ExecuteFile(RutaYNombre, scope);
        //        ret = Convert.ToString(scope.GetVariable("Resultado"));
        //    }
        //    catch (Exception)
        //    {

        //        ret = false;
        //    }
        //    return ret;
        //}
        //public void Crear_Archivo_Script(String Condicion_A_Evaluar, String RutaYNombre)
        //{

        //    System.IO.StreamWriter script = new System.IO.StreamWriter(RutaYNombre);

        //    script.WriteLine("def Evaluar():");
        //    script.WriteLine("\tRet = False");
        //    script.WriteLine("\tif (" + Condicion_A_Evaluar + "):");
        //    script.WriteLine("\t\tRet = True");
        //    script.WriteLine("\telse:");
        //    script.WriteLine("\t\tRet = False");
        //    script.WriteLine("\treturn Ret");
        //    script.WriteLine();
        //    script.WriteLine("Resultado = Evaluar()");
        //    script.Close();


        //}

        //public string Crear_Sentencia_Condicional(string condicion,byte[]Datos)
        //{
        //    string ret="";
        //    string eval = condicion;

        //    for (int n = 0; n < BufferTX[11].Length; n++)
        //    {
        //        eval = eval.Replace("B[" + n + "]", BufferTX[11][n].ToString());
        //    }
        //    for (int n = 0; n < Datos.Length; n++)
        //    {
        //        eval = eval.Replace("RX[" + n + "]", Datos[n].ToString());
        //    }
        //    return ret;
        //}
        //public Boolean Verificar_Sintaxis_Condicional(string sentencia)
        //{
        //    Boolean ret = true;
        //    try 
	       // {	        
		      //  ScriptSource source = engine.CreateScriptSourceFromString(sentencia,SourceCodeKind.AutoDetect);
        //        source.Compile();
        //        ret = true;
	       // }
	       // catch (Exception)
	       // {
		
		      //  ret = false;
	       // }
            

        //    return ret;
        //}
        //private Boolean Evaluar_Condicional(string sentencia)
        //{
        //    Boolean ret=true;
        //    try 
	       // {	        
		      //  ScriptSource source = engine.CreateScriptSourceFromString(sentencia,SourceCodeKind.AutoDetect);
        //        //source.Compile();

        //        object result = source.Execute(scope);
        //        ret =Convert.ToBoolean(result);
	       // }
	       // catch (Exception)
	       // {		
		      //  ret = false;
	       // }
        //    return ret;
        //}
        //#endregion

        private void TIM_TX_Auto_Tick(object sender, EventArgs e)
        {
            if (PS != null)
            {
                if (PS.IsOpen)
                {
                    if (TransmisionAutomatica && TransmisionPeriodica)
                    {
                        Transmitir(BufferTX[NumeroBufferTXAUTO_Periodica-1]);
                    }
                }
            }
        }



























    }
}
