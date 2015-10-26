namespace TR
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.portasSerialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarEquipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.percursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrancadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.percursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.l7 = new System.Windows.Forms.Label();
            this.l8 = new System.Windows.Forms.Label();
            this.l9 = new System.Windows.Forms.Label();
            this.l10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.message = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portasSerialToolStripMenuItem,
            this.adicionarEquipesToolStripMenuItem,
            this.percursosToolStripMenuItem,
            this.messageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // portasSerialToolStripMenuItem
            // 
            this.portasSerialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portasToolStripMenuItem,
            this.conectarToolStripMenuItem,
            this.desconectarToolStripMenuItem});
            this.portasSerialToolStripMenuItem.Name = "portasSerialToolStripMenuItem";
            this.portasSerialToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.portasSerialToolStripMenuItem.Text = "Portas Serial";
            // 
            // portasToolStripMenuItem
            // 
            this.portasToolStripMenuItem.Name = "portasToolStripMenuItem";
            this.portasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.portasToolStripMenuItem.Text = "portas";
            this.portasToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripDropDownItem_DropDownItemClicked);
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.conectarToolStripMenuItem.Text = "conectar";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.desconectarToolStripMenuItem.Text = "desconectar";
            this.desconectarToolStripMenuItem.Click += new System.EventHandler(this.desconectarToolStripMenuItem_Click);
            // 
            // adicionarEquipesToolStripMenuItem
            // 
            this.adicionarEquipesToolStripMenuItem.Name = "adicionarEquipesToolStripMenuItem";
            this.adicionarEquipesToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.adicionarEquipesToolStripMenuItem.Text = "adicionar equipes";
            this.adicionarEquipesToolStripMenuItem.Click += new System.EventHandler(this.adicionarEquipesToolStripMenuItem_Click);
            // 
            // percursosToolStripMenuItem
            // 
            this.percursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrancadaToolStripMenuItem,
            this.percursoToolStripMenuItem});
            this.percursosToolStripMenuItem.Name = "percursosToolStripMenuItem";
            this.percursosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.percursosToolStripMenuItem.Text = "percursos";
            // 
            // arrancadaToolStripMenuItem
            // 
            this.arrancadaToolStripMenuItem.Name = "arrancadaToolStripMenuItem";
            this.arrancadaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.arrancadaToolStripMenuItem.Text = "Arrancada";
            this.arrancadaToolStripMenuItem.Click += new System.EventHandler(this.arrancadaToolStripMenuItem_Click);
            // 
            // percursoToolStripMenuItem
            // 
            this.percursoToolStripMenuItem.Name = "percursoToolStripMenuItem";
            this.percursoToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.percursoToolStripMenuItem.Text = "Percurso";
            this.percursoToolStripMenuItem.Click += new System.EventHandler(this.percursoToolStripMenuItem_Click);
            // 
            // messageToolStripMenuItem
            // 
            this.messageToolStripMenuItem.Name = "messageToolStripMenuItem";
            this.messageToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.messageToolStripMenuItem.Text = "message";
            this.messageToolStripMenuItem.Click += new System.EventHandler(this.messageToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tempo Lombada:";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(142, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "proxima equipe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(12, 552);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "equipe anterior";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TR.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Início:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(220, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 39);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fim:";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.BackColor = System.Drawing.Color.Transparent;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(157, 299);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(75, 39);
            this.l1.TabIndex = 10;
            this.l1.Text = "IDA";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.BackColor = System.Drawing.Color.Transparent;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(477, 299);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(129, 39);
            this.l2.TabIndex = 11;
            this.l2.Text = "VOLTA";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.BackColor = System.Drawing.Color.Transparent;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.Location = new System.Drawing.Point(90, 343);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(142, 31);
            this.l3.TabIndex = 12;
            this.l3.Text = "MARCA 1:";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.BackColor = System.Drawing.Color.Transparent;
            this.l4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4.Location = new System.Drawing.Point(407, 343);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(142, 31);
            this.l4.TabIndex = 13;
            this.l4.Text = "MARCA 1:";
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.BackColor = System.Drawing.Color.Transparent;
            this.l5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l5.Location = new System.Drawing.Point(90, 395);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(142, 31);
            this.l5.TabIndex = 15;
            this.l5.Text = "MARCA 2:";
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.BackColor = System.Drawing.Color.Transparent;
            this.l6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l6.Location = new System.Drawing.Point(407, 395);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(142, 31);
            this.l6.TabIndex = 16;
            this.l6.Text = "MARCA 2:";
            // 
            // l7
            // 
            this.l7.AutoSize = true;
            this.l7.BackColor = System.Drawing.Color.Transparent;
            this.l7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l7.Location = new System.Drawing.Point(90, 443);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(142, 31);
            this.l7.TabIndex = 17;
            this.l7.Text = "MARCA 3:";
            // 
            // l8
            // 
            this.l8.AutoSize = true;
            this.l8.BackColor = System.Drawing.Color.Transparent;
            this.l8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l8.Location = new System.Drawing.Point(407, 443);
            this.l8.Name = "l8";
            this.l8.Size = new System.Drawing.Size(142, 31);
            this.l8.TabIndex = 18;
            this.l8.Text = "MARCA 3:";
            // 
            // l9
            // 
            this.l9.AutoSize = true;
            this.l9.BackColor = System.Drawing.Color.Transparent;
            this.l9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l9.Location = new System.Drawing.Point(90, 495);
            this.l9.Name = "l9";
            this.l9.Size = new System.Drawing.Size(133, 31);
            this.l9.TabIndex = 19;
            this.l9.Text = "VOLTA 1:";
            // 
            // l10
            // 
            this.l10.AutoSize = true;
            this.l10.BackColor = System.Drawing.Color.Transparent;
            this.l10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l10.Location = new System.Drawing.Point(407, 495);
            this.l10.Name = "l10";
            this.l10.Size = new System.Drawing.Size(133, 31);
            this.l10.TabIndex = 20;
            this.l10.Text = "VOLTA 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(367, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 40);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tempo Total: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(477, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 39);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tempo Total:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::TR.Properties.Resources.baak_1;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(792, 587);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.BackColor = System.Drawing.Color.Transparent;
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(375, 192);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(84, 39);
            this.message.TabIndex = 24;
            this.message.Text = "TDT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TR.Properties.Resources.baak;
            this.ClientSize = new System.Drawing.Size(792, 587);
            this.Controls.Add(this.message);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.l10);
            this.Controls.Add(this.l9);
            this.Controls.Add(this.l8);
            this.Controls.Add(this.l7);
            this.Controls.Add(this.l6);
            this.Controls.Add(this.l5);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem portasSerialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portasToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarEquipesToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem percursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrancadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem percursoToolStripMenuItem;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.Label l7;
        private System.Windows.Forms.Label l8;
        private System.Windows.Forms.Label l9;
        private System.Windows.Forms.Label l10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem;
        private System.Windows.Forms.Label message;
    }
}

