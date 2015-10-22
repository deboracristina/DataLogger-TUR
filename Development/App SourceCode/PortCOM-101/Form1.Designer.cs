namespace PortCOM_101
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.mySerialPort = new System.IO.Ports.SerialPort(this.components);
            this.cbPortName = new System.Windows.Forms.ComboBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.rtbSerialData = new System.Windows.Forms.RichTextBox();
            this.btDesconectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mySerialPort
            // 
            this.mySerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.mySerialPort_DataReceived);
            // 
            // cbPortName
            // 
            this.cbPortName.FormattingEnabled = true;
            this.cbPortName.Location = new System.Drawing.Point(12, 12);
            this.cbPortName.Name = "cbPortName";
            this.cbPortName.Size = new System.Drawing.Size(75, 21);
            this.cbPortName.TabIndex = 0;
            this.cbPortName.SelectedIndexChanged += new System.EventHandler(this.cbPortName_SelectedIndexChanged);
            this.cbPortName.Click += new System.EventHandler(this.cbPortName_Click);
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(104, 12);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(78, 23);
            this.btConnect.TabIndex = 1;
            this.btConnect.Text = "Conectar";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // rtbSerialData
            // 
            this.rtbSerialData.Location = new System.Drawing.Point(12, 141);
            this.rtbSerialData.Name = "rtbSerialData";
            this.rtbSerialData.Size = new System.Drawing.Size(167, 167);
            this.rtbSerialData.TabIndex = 2;
            this.rtbSerialData.Text = "";
            // 
            // btDesconectar
            // 
            this.btDesconectar.Location = new System.Drawing.Point(104, 41);
            this.btDesconectar.Name = "btDesconectar";
            this.btDesconectar.Size = new System.Drawing.Size(78, 23);
            this.btDesconectar.TabIndex = 3;
            this.btDesconectar.Text = "Desconectar";
            this.btDesconectar.UseVisualStyleBackColor = true;
            this.btDesconectar.Click += new System.EventHandler(this.btDesconectar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 320);
            this.Controls.Add(this.btDesconectar);
            this.Controls.Add(this.rtbSerialData);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.cbPortName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort mySerialPort;
        private System.Windows.Forms.ComboBox cbPortName;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.RichTextBox rtbSerialData;
        private System.Windows.Forms.Button btDesconectar;
    }
}

