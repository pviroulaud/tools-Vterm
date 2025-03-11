namespace V_Term
{
    partial class Form_Configuracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Configuracion));
            this.Button1 = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.CBox_Velocidad = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.CBox_BitStop = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.CBox_Bits = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.CBox_Paridad = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.CBox_Puertos = new System.Windows.Forms.ComboBox();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(111, 25);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(92, 20);
            this.Button1.TabIndex = 25;
            this.Button1.Text = "Refrescar";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(108, 92);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(80, 13);
            this.Label5.TabIndex = 24;
            this.Label5.Text = "Velocidad (bps)";
            // 
            // CBox_Velocidad
            // 
            this.CBox_Velocidad.FormattingEnabled = true;
            this.CBox_Velocidad.Location = new System.Drawing.Point(111, 108);
            this.CBox_Velocidad.Name = "CBox_Velocidad";
            this.CBox_Velocidad.Size = new System.Drawing.Size(92, 21);
            this.CBox_Velocidad.TabIndex = 23;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(3, 92);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(59, 13);
            this.Label4.TabIndex = 22;
            this.Label4.Text = "Bit de Stop";
            // 
            // CBox_BitStop
            // 
            this.CBox_BitStop.FormattingEnabled = true;
            this.CBox_BitStop.Location = new System.Drawing.Point(6, 108);
            this.CBox_BitStop.Name = "CBox_BitStop";
            this.CBox_BitStop.Size = new System.Drawing.Size(92, 21);
            this.CBox_BitStop.TabIndex = 21;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(108, 52);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(70, 13);
            this.Label3.TabIndex = 20;
            this.Label3.Text = "Bits de Datos";
            // 
            // CBox_Bits
            // 
            this.CBox_Bits.FormattingEnabled = true;
            this.CBox_Bits.Location = new System.Drawing.Point(111, 68);
            this.CBox_Bits.Name = "CBox_Bits";
            this.CBox_Bits.Size = new System.Drawing.Size(92, 21);
            this.CBox_Bits.TabIndex = 19;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(3, 52);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(43, 13);
            this.Label2.TabIndex = 18;
            this.Label2.Text = "Paridad";
            // 
            // CBox_Paridad
            // 
            this.CBox_Paridad.FormattingEnabled = true;
            this.CBox_Paridad.Location = new System.Drawing.Point(6, 68);
            this.CBox_Paridad.Name = "CBox_Paridad";
            this.CBox_Paridad.Size = new System.Drawing.Size(92, 21);
            this.CBox_Paridad.TabIndex = 17;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(3, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(38, 13);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "Puerto";
            // 
            // CBox_Puertos
            // 
            this.CBox_Puertos.FormattingEnabled = true;
            this.CBox_Puertos.Location = new System.Drawing.Point(6, 25);
            this.CBox_Puertos.Name = "CBox_Puertos";
            this.CBox_Puertos.Size = new System.Drawing.Size(92, 21);
            this.CBox_Puertos.TabIndex = 15;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 1, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(225, 97);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(76, 29);
            this.TableLayoutPanel1.TabIndex = 14;
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.Location = new System.Drawing.Point(4, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(67, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "Aceptar";
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Form_Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 138);
            this.ControlBox = false;
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.CBox_Velocidad);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.CBox_BitStop);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.CBox_Bits);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.CBox_Paridad);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.CBox_Puertos);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Configuracion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Configuracion";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Configuracion_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button OK_Button;
        public System.Windows.Forms.ComboBox CBox_Velocidad;
        public System.Windows.Forms.ComboBox CBox_BitStop;
        public System.Windows.Forms.ComboBox CBox_Bits;
        public System.Windows.Forms.ComboBox CBox_Paridad;
        public System.Windows.Forms.ComboBox CBox_Puertos;
    }
}