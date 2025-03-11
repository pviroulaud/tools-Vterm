namespace V_Term
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logDeEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bytesRecibidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.buffersDeTransmisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionDeConexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.abrirVSPEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirEditorHexadecimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puertoSerialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.protocoloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bufferDeTransmisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionDeRecepcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logDeComunicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transmisionRecepcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recepcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.terminalTxRxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vTERMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.C_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Puerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_TxRx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Long = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_array = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.led7 = new ControlesVARIOS.LED();
            this.label7 = new System.Windows.Forms.Label();
            this.led6 = new ControlesVARIOS.LED();
            this.label6 = new System.Windows.Forms.Label();
            this.led5 = new ControlesVARIOS.LED();
            this.label5 = new System.Windows.Forms.Label();
            this.led4 = new ControlesVARIOS.LED();
            this.label4 = new System.Windows.Forms.Label();
            this.led3 = new ControlesVARIOS.LED();
            this.label3 = new System.Windows.Forms.Label();
            this.led2 = new ControlesVARIOS.LED();
            this.label2 = new System.Windows.Forms.Label();
            this.led1 = new ControlesVARIOS.LED();
            this.label1 = new System.Windows.Forms.Label();
            this.rtc = new System.Windows.Forms.Timer(this.components);
            this.ASCIIHEX_1 = new HEX.HEX_Editor();
            this.ASCIIHEX_2 = new HEX.HEX_Editor();
            this.HEXEDIT_LOG = new HEX.HEX_Editor();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Terminal = new HEX.HEX_Editor();
            this.TIM_TX_Auto = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.conexionToolStripMenuItem,
            this.protocoloToolStripMenuItem,
            this.verToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(965, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirSesionToolStripMenuItem,
            this.guardarTodoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.toolStripSeparator3,
            this.abrirVSPEToolStripMenuItem,
            this.abrirEditorHexadecimalToolStripMenuItem,
            this.toolStripSeparator4,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirSesionToolStripMenuItem
            // 
            this.abrirSesionToolStripMenuItem.Name = "abrirSesionToolStripMenuItem";
            this.abrirSesionToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.abrirSesionToolStripMenuItem.Text = "Abrir Sesion";
            this.abrirSesionToolStripMenuItem.Click += new System.EventHandler(this.abrirSesionToolStripMenuItem_Click);
            // 
            // guardarTodoToolStripMenuItem
            // 
            this.guardarTodoToolStripMenuItem.Name = "guardarTodoToolStripMenuItem";
            this.guardarTodoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.guardarTodoToolStripMenuItem.Text = "Guardar Sesion";
            this.guardarTodoToolStripMenuItem.Click += new System.EventHandler(this.guardarTodoToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logDeEventosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.bytesRecibidosToolStripMenuItem,
            this.toolStripMenuItem2,
            this.buffersDeTransmisionToolStripMenuItem,
            this.configuracionDeConexionToolStripMenuItem});
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // logDeEventosToolStripMenuItem
            // 
            this.logDeEventosToolStripMenuItem.Name = "logDeEventosToolStripMenuItem";
            this.logDeEventosToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.logDeEventosToolStripMenuItem.Text = "Log de Eventos";
            this.logDeEventosToolStripMenuItem.Click += new System.EventHandler(this.logDeEventosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(217, 22);
            this.toolStripMenuItem1.Text = "Bytes Transmitidos";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // bytesRecibidosToolStripMenuItem
            // 
            this.bytesRecibidosToolStripMenuItem.Name = "bytesRecibidosToolStripMenuItem";
            this.bytesRecibidosToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.bytesRecibidosToolStripMenuItem.Text = "Bytes Recibidos";
            this.bytesRecibidosToolStripMenuItem.Click += new System.EventHandler(this.bytesRecibidosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(217, 22);
            this.toolStripMenuItem2.Text = "Vista de Terminal";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // buffersDeTransmisionToolStripMenuItem
            // 
            this.buffersDeTransmisionToolStripMenuItem.Name = "buffersDeTransmisionToolStripMenuItem";
            this.buffersDeTransmisionToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.buffersDeTransmisionToolStripMenuItem.Text = "Buffers de transmision";
            this.buffersDeTransmisionToolStripMenuItem.Click += new System.EventHandler(this.buffersDeTransmisionToolStripMenuItem_Click);
            // 
            // configuracionDeConexionToolStripMenuItem
            // 
            this.configuracionDeConexionToolStripMenuItem.Name = "configuracionDeConexionToolStripMenuItem";
            this.configuracionDeConexionToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.configuracionDeConexionToolStripMenuItem.Text = "Configuracion de conexion";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(202, 6);
            // 
            // abrirVSPEToolStripMenuItem
            // 
            this.abrirVSPEToolStripMenuItem.Name = "abrirVSPEToolStripMenuItem";
            this.abrirVSPEToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.abrirVSPEToolStripMenuItem.Text = "Abrir VSPE";
            this.abrirVSPEToolStripMenuItem.Click += new System.EventHandler(this.abrirVSPEToolStripMenuItem_Click);
            // 
            // abrirEditorHexadecimalToolStripMenuItem
            // 
            this.abrirEditorHexadecimalToolStripMenuItem.Name = "abrirEditorHexadecimalToolStripMenuItem";
            this.abrirEditorHexadecimalToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.abrirEditorHexadecimalToolStripMenuItem.Text = "Abrir Editor Hexadecimal";
            this.abrirEditorHexadecimalToolStripMenuItem.Click += new System.EventHandler(this.abrirEditorHexadecimalToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(202, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // conexionToolStripMenuItem
            // 
            this.conexionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puertoSerialToolStripMenuItem});
            this.conexionToolStripMenuItem.Name = "conexionToolStripMenuItem";
            this.conexionToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.conexionToolStripMenuItem.Text = "Conexion";
            // 
            // puertoSerialToolStripMenuItem
            // 
            this.puertoSerialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionToolStripMenuItem,
            this.toolStripSeparator1,
            this.conectarToolStripMenuItem,
            this.desconectarToolStripMenuItem});
            this.puertoSerialToolStripMenuItem.Name = "puertoSerialToolStripMenuItem";
            this.puertoSerialToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.puertoSerialToolStripMenuItem.Text = "Puerto Serial";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.configuracionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            this.configuracionToolStripMenuItem.Click += new System.EventHandler(this.configuracionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.conectarToolStripMenuItem.Text = "Conectar";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.desconectarToolStripMenuItem.Text = "Desconectar";
            this.desconectarToolStripMenuItem.Click += new System.EventHandler(this.desconectarToolStripMenuItem_Click);
            // 
            // protocoloToolStripMenuItem
            // 
            this.protocoloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bufferDeTransmisionToolStripMenuItem,
            this.configuracionDeRecepcionToolStripMenuItem});
            this.protocoloToolStripMenuItem.Name = "protocoloToolStripMenuItem";
            this.protocoloToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.protocoloToolStripMenuItem.Text = "Protocolo";
            // 
            // bufferDeTransmisionToolStripMenuItem
            // 
            this.bufferDeTransmisionToolStripMenuItem.Name = "bufferDeTransmisionToolStripMenuItem";
            this.bufferDeTransmisionToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.bufferDeTransmisionToolStripMenuItem.Text = "Buffer de transmision";
            this.bufferDeTransmisionToolStripMenuItem.ToolTipText = "Presione la tecla [F1] -[F12] para iniciar latransmision del Buffer correspondien" +
    "te";
            this.bufferDeTransmisionToolStripMenuItem.Click += new System.EventHandler(this.bufferDeTransmisionToolStripMenuItem_Click);
            // 
            // configuracionDeRecepcionToolStripMenuItem
            // 
            this.configuracionDeRecepcionToolStripMenuItem.Name = "configuracionDeRecepcionToolStripMenuItem";
            this.configuracionDeRecepcionToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.configuracionDeRecepcionToolStripMenuItem.Text = "Configuracion de recepcion";
            this.configuracionDeRecepcionToolStripMenuItem.Click += new System.EventHandler(this.configuracionDeRecepcionToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logDeComunicacionesToolStripMenuItem,
            this.transmisionRecepcionToolStripMenuItem,
            this.recepcionToolStripMenuItem,
            this.toolStripSeparator2,
            this.terminalTxRxToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.verToolStripMenuItem.Text = "Ver Registros";
            // 
            // logDeComunicacionesToolStripMenuItem
            // 
            this.logDeComunicacionesToolStripMenuItem.Name = "logDeComunicacionesToolStripMenuItem";
            this.logDeComunicacionesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.logDeComunicacionesToolStripMenuItem.Text = "Log de comunicaciones";
            this.logDeComunicacionesToolStripMenuItem.Click += new System.EventHandler(this.logDeComunicacionesToolStripMenuItem_Click);
            // 
            // transmisionRecepcionToolStripMenuItem
            // 
            this.transmisionRecepcionToolStripMenuItem.Name = "transmisionRecepcionToolStripMenuItem";
            this.transmisionRecepcionToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.transmisionRecepcionToolStripMenuItem.Text = "Transmision | Recepcion";
            this.transmisionRecepcionToolStripMenuItem.Click += new System.EventHandler(this.transmisionRecepcionToolStripMenuItem_Click);
            // 
            // recepcionToolStripMenuItem
            // 
            this.recepcionToolStripMenuItem.Name = "recepcionToolStripMenuItem";
            this.recepcionToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.recepcionToolStripMenuItem.Text = "Recepcion";
            this.recepcionToolStripMenuItem.Click += new System.EventHandler(this.recepcionToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(200, 6);
            // 
            // terminalTxRxToolStripMenuItem
            // 
            this.terminalTxRxToolStripMenuItem.Name = "terminalTxRxToolStripMenuItem";
            this.terminalTxRxToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.terminalTxRxToolStripMenuItem.Text = "Terminal (Tx | Rx)";
            this.terminalTxRxToolStripMenuItem.Click += new System.EventHandler(this.terminalTxRxToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vTERMToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca De";
            // 
            // vTERMToolStripMenuItem
            // 
            this.vTERMToolStripMenuItem.Name = "vTERMToolStripMenuItem";
            this.vTERMToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.vTERMToolStripMenuItem.Text = "V TERM";
            this.vTERMToolStripMenuItem.Click += new System.EventHandler(this.vTERMToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_Fecha,
            this.C_Hora,
            this.C_IP,
            this.C_Puerto,
            this.C_TxRx,
            this.C_Long,
            this.C_array});
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(941, 93);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // C_Fecha
            // 
            this.C_Fecha.HeaderText = "Fecha";
            this.C_Fecha.Name = "C_Fecha";
            this.C_Fecha.ReadOnly = true;
            this.C_Fecha.Width = 62;
            // 
            // C_Hora
            // 
            this.C_Hora.HeaderText = "Hora";
            this.C_Hora.Name = "C_Hora";
            this.C_Hora.ReadOnly = true;
            this.C_Hora.Width = 55;
            // 
            // C_IP
            // 
            this.C_IP.HeaderText = "IP";
            this.C_IP.Name = "C_IP";
            this.C_IP.ReadOnly = true;
            this.C_IP.Width = 42;
            // 
            // C_Puerto
            // 
            this.C_Puerto.HeaderText = "Puerto";
            this.C_Puerto.Name = "C_Puerto";
            this.C_Puerto.ReadOnly = true;
            this.C_Puerto.Width = 63;
            // 
            // C_TxRx
            // 
            this.C_TxRx.HeaderText = "Tx/Rx";
            this.C_TxRx.Name = "C_TxRx";
            this.C_TxRx.ReadOnly = true;
            this.C_TxRx.Width = 62;
            // 
            // C_Long
            // 
            this.C_Long.HeaderText = "Cant Bytes";
            this.C_Long.Name = "C_Long";
            this.C_Long.ReadOnly = true;
            this.C_Long.Width = 83;
            // 
            // C_array
            // 
            this.C_array.HeaderText = "Bytes";
            this.C_array.Name = "C_array";
            this.C_array.ReadOnly = true;
            this.C_array.Width = 58;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.led7);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.led6);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.led5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.led4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.led3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.led2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.led1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(105, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 56);
            this.panel1.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.label9.Location = new System.Drawing.Point(7, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "DESC";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.label8.Location = new System.Drawing.Point(7, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "CONECT";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // led7
            // 
            this.led7.BackColor = System.Drawing.Color.Transparent;
            this.led7.Color_LED = ControlesVARIOS.LED.ControlLED_Colores.Apagado;
            this.led7.Destellar = false;
            this.led7.Intervalo_Blink = 0;
            this.led7.Location = new System.Drawing.Point(247, 26);
            this.led7.Name = "led7";
            this.led7.Size = new System.Drawing.Size(17, 17);
            this.led7.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "CD";
            // 
            // led6
            // 
            this.led6.BackColor = System.Drawing.Color.Transparent;
            this.led6.Color_LED = ControlesVARIOS.LED.ControlLED_Colores.Apagado;
            this.led6.Destellar = false;
            this.led6.Intervalo_Blink = 0;
            this.led6.Location = new System.Drawing.Point(216, 26);
            this.led6.Name = "led6";
            this.led6.Size = new System.Drawing.Size(17, 17);
            this.led6.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "CTS";
            // 
            // led5
            // 
            this.led5.BackColor = System.Drawing.Color.Transparent;
            this.led5.Color_LED = ControlesVARIOS.LED.ControlLED_Colores.Apagado;
            this.led5.Destellar = false;
            this.led5.Intervalo_Blink = 0;
            this.led5.Location = new System.Drawing.Point(181, 26);
            this.led5.Name = "led5";
            this.led5.Size = new System.Drawing.Size(17, 17);
            this.led5.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(175, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "RTS";
            this.label5.DoubleClick += new System.EventHandler(this.label5_DoubleClick);
            // 
            // led4
            // 
            this.led4.BackColor = System.Drawing.Color.Transparent;
            this.led4.Color_LED = ControlesVARIOS.LED.ControlLED_Colores.Apagado;
            this.led4.Destellar = false;
            this.led4.Intervalo_Blink = 0;
            this.led4.Location = new System.Drawing.Point(145, 26);
            this.led4.Name = "led4";
            this.led4.Size = new System.Drawing.Size(17, 17);
            this.led4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "DSR";
            // 
            // led3
            // 
            this.led3.BackColor = System.Drawing.Color.Transparent;
            this.led3.Color_LED = ControlesVARIOS.LED.ControlLED_Colores.Apagado;
            this.led3.Destellar = false;
            this.led3.Intervalo_Blink = 0;
            this.led3.Location = new System.Drawing.Point(109, 26);
            this.led3.Name = "led3";
            this.led3.Size = new System.Drawing.Size(17, 17);
            this.led3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(103, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "DTR";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.DoubleClick += new System.EventHandler(this.label3_DoubleClick);
            // 
            // led2
            // 
            this.led2.BackColor = System.Drawing.Color.Transparent;
            this.led2.Color_LED = ControlesVARIOS.LED.ControlLED_Colores.Apagado;
            this.led2.Destellar = false;
            this.led2.Intervalo_Blink = 30;
            this.led2.Location = new System.Drawing.Point(74, 26);
            this.led2.Name = "led2";
            this.led2.Size = new System.Drawing.Size(17, 17);
            this.led2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "RX";
            // 
            // led1
            // 
            this.led1.BackColor = System.Drawing.Color.Transparent;
            this.led1.Color_LED = ControlesVARIOS.LED.ControlLED_Colores.Verde;
            this.led1.Destellar = false;
            this.led1.Intervalo_Blink = 30;
            this.led1.Location = new System.Drawing.Point(51, 26);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(17, 17);
            this.led1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TX";
            // 
            // rtc
            // 
            this.rtc.Enabled = true;
            this.rtc.Interval = 500;
            this.rtc.Tick += new System.EventHandler(this.rtc_Tick);
            // 
            // ASCIIHEX_1
            // 
            this.ASCIIHEX_1.Edicion_Habilitada = true;
            this.ASCIIHEX_1.Location = new System.Drawing.Point(25, 135);
            this.ASCIIHEX_1.Name = "ASCIIHEX_1";
            this.ASCIIHEX_1.Size = new System.Drawing.Size(207, 137);
            this.ASCIIHEX_1.TabIndex = 6;
            this.ASCIIHEX_1.Titulo = "TITULO";
            this.ASCIIHEX_1.VER = HEX.HEX_Editor.Vistas.HEX_ASCII;
            this.ASCIIHEX_1.VER_Titulo = true;
            // 
            // ASCIIHEX_2
            // 
            this.ASCIIHEX_2.Edicion_Habilitada = true;
            this.ASCIIHEX_2.Location = new System.Drawing.Point(261, 126);
            this.ASCIIHEX_2.Name = "ASCIIHEX_2";
            this.ASCIIHEX_2.Size = new System.Drawing.Size(171, 138);
            this.ASCIIHEX_2.TabIndex = 7;
            this.ASCIIHEX_2.Titulo = "TITULO";
            this.ASCIIHEX_2.VER = HEX.HEX_Editor.Vistas.HEX_ASCII;
            this.ASCIIHEX_2.VER_Titulo = true;
            // 
            // HEXEDIT_LOG
            // 
            this.HEXEDIT_LOG.Edicion_Habilitada = true;
            this.HEXEDIT_LOG.Location = new System.Drawing.Point(438, 126);
            this.HEXEDIT_LOG.Name = "HEXEDIT_LOG";
            this.HEXEDIT_LOG.Size = new System.Drawing.Size(244, 137);
            this.HEXEDIT_LOG.TabIndex = 8;
            this.HEXEDIT_LOG.Titulo = "TITULO";
            this.HEXEDIT_LOG.VER = HEX.HEX_Editor.Vistas.HEX_ASCII;
            this.HEXEDIT_LOG.VER_Titulo = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Terminal
            // 
            this.Terminal.Edicion_Habilitada = true;
            this.Terminal.Location = new System.Drawing.Point(688, 127);
            this.Terminal.Name = "Terminal";
            this.Terminal.Size = new System.Drawing.Size(244, 137);
            this.Terminal.TabIndex = 9;
            this.Terminal.Titulo = "TITULO";
            this.Terminal.VER = HEX.HEX_Editor.Vistas.HEX_ASCII;
            this.Terminal.VER_Titulo = true;
            // 
            // TIM_TX_Auto
            // 
            this.TIM_TX_Auto.Interval = 10;
            this.TIM_TX_Auto.Tick += new System.EventHandler(this.TIM_TX_Auto_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 384);
            this.Controls.Add(this.Terminal);
            this.Controls.Add(this.HEXEDIT_LOG);
            this.Controls.Add(this.ASCIIHEX_2);
            this.Controls.Add(this.ASCIIHEX_1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "V-TERM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puertoSerialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Puerto;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_TxRx;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Long;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_array;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logDeComunicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transmisionRecepcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recepcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem terminalTxRxToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private ControlesVARIOS.LED led1;
        private System.Windows.Forms.Label label1;
        private ControlesVARIOS.LED led5;
        private System.Windows.Forms.Label label5;
        private ControlesVARIOS.LED led4;
        private System.Windows.Forms.Label label4;
        private ControlesVARIOS.LED led3;
        private System.Windows.Forms.Label label3;
        private ControlesVARIOS.LED led2;
        private System.Windows.Forms.Label label2;
        private ControlesVARIOS.LED led6;
        private System.Windows.Forms.Label label6;
        private ControlesVARIOS.LED led7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer rtc;
        private System.Windows.Forms.ToolStripMenuItem protocoloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bufferDeTransmisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionDeRecepcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vTERMToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private HEX.HEX_Editor ASCIIHEX_1;
        private HEX.HEX_Editor ASCIIHEX_2;
        private HEX.HEX_Editor HEXEDIT_LOG;
        private System.Windows.Forms.ToolStripMenuItem guardarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logDeEventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bytesRecibidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem buffersDeTransmisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionDeConexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem abrirEditorHexadecimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private HEX.HEX_Editor Terminal;
        private System.Windows.Forms.ToolStripMenuItem abrirVSPEToolStripMenuItem;
        private System.Windows.Forms.Timer TIM_TX_Auto;
    }
}

