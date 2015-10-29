using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace TR
{
    public partial class Form1 : Form
    {
        SerialPort sp = new SerialPort();
        Class1 cl = new Class1();
        equipes eq = new equipes();
        equipes peq = new equipes();
        message ms = new message();
        String[] sn;
        string msg;
        int cont = 0;

        ControllerData cd= new ControllerData();

        bool flagInit = false;

        public Form1()
        {
            InitializeComponent();
            sp.BaudRate = 19200;
            sn = SerialPort.GetPortNames();

            foreach (string s in SerialPort.GetPortNames())
            {
                portasToolStripMenuItem.DropDownItems.Add(s);
            }

            l1.Visible = false;
            l2.Visible = false;
            l3.Visible = false;
            l4.Visible = false;
            l5.Visible = false;
            l6.Visible = false;
            l7.Visible = false;
            l8.Visible = false;
            l9.Visible = false;
            l10.Visible = false;
            label7.Visible = false;
            logo.BringToFront();
            message.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(!flagInit)
            {
                try // abre a porta
                {
                    if (!sp.IsOpen)
                    {
                        sp.Open();
                        flagInit = true;
                        Console.WriteLine("Conectou!");
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                
            }
            else
            {
                //sp.Write("a"); // envia um cartacter
                /*Força a leitura da porta serial para eliminar os dados do buffer.*/
                //int readCount = sp.BytesToRead;
                //byte[] gbuffer = new byte[readCount];
                //sp.Read(gbuffer, 0, readCount);
                sp.ReadExisting();

                sp.Write("a"); //reenvia informação para solicitar dados do mcu
                Thread.Sleep(70);
                char[] buffer = new char[66];
                string[] vars = new string[14];

                if (sp.BytesToRead >= 66)
                {
                    sp.Read(buffer, 0, 66);
                    vars[0] = buffer[0].ToString();
                    for (int i = 0; i < 13; i++)
                    {
                        vars[i + 1] = buffer[i * 5 + 1].ToString()
                                    + buffer[i * 5 + 2].ToString()
                                    + buffer[i * 5 + 3].ToString()
                                    + buffer[i * 5 + 4].ToString()
                                    + buffer[i * 5 + 5].ToString();
                    }

                    atualiza(vars);
                    Console.WriteLine();
                } 

                
            }
            
        } // timer lançado a cada 100ms

        void toolStripDropDownItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            msg = String.Format("{0}", e.ClickedItem.Text);
            if (sp.IsOpen)
            { sp.Close(); }
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(msg == null)
            {
                MessageBox.Show("Nenhuma Porta selecionada!");
            }
            else
            {
                cont = 0;
                sp.Close();
                sp.PortName = msg;
                timer1.Enabled = true;
                timer1.Start();
                button1.Enabled = true;
                button2.Enabled = true;
                MessageBox.Show("conectado!");
            }
        }// conecta porta serial

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logo.BringToFront();
            message.BringToFront();
            logo.Visible = true;
            messageToolStripMenuItem.Enabled =  true;
            message.Visible = true;
            timer1.Enabled = false;
            sp.Close();
        }// Volta para tela inicail e desconecta a porta serial

        private void button1_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                cont = 1;
            }
            if (cont < eq.line)
            {
                cont++;
                label2.Text = eq.s[cont - 1];
            }
        }  // seleciona a equipe seguinte

        private void button2_Click(object sender, EventArgs e)
        {
            if (cont > 1)
            {
                cont--;
                label2.Text = eq.s[cont - 1];
            }
        } // seleciona a equipe anterior

        private void arrancadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (eq.line == 0)
            {
                MessageBox.Show("Adicione equipes!");
            }
            else
            {
                if (cd.categoria != null)
                {
                    if (cd.categoria.Equals("0"))
                    {
                        logo.Visible = false;
                        message.Visible = false;
                        messageToolStripMenuItem.Enabled = false;
                        label1.Text = "Categoria:" + " ARRANCADA";
                        this.BackgroundImage = new Bitmap(@"C:\GitHub\DataLogger-TUR\Development\TR\TR\Resources\baak.jpg");
                        label3.Text = "Tempo Lombada: " + cl.vars[4];
                        label4.Visible = true;
                        label5.Visible = true;
                        l1.Visible = false;
                        l2.Visible = false;
                        l3.Visible = false;
                        l4.Visible = false;
                        l5.Visible = false;
                        l6.Visible = false;
                        l7.Visible = false;
                        l8.Visible = false;
                        l9.Visible = false;
                        l10.Visible = false;
                        label2.Location = new Point(322, 210);
                        label3.Visible = true;
                        label6.Visible = true;
                        label7.Visible = false;
                        if (cont >(eq.s.Length-1))
                            cont--;
                        label2.Text =  eq.s[cont];
                    }
                    else MessageBox.Show("Mude a chave!");
                }
            }
        } // deixa visivel tudo da arrancada

        private void percursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (eq.line == 0)
            {
                MessageBox.Show("Adicione equipes!");
            }
            else
            {
                if (cd.categoria != null)
                {
                    if (cd.categoria.Equals("1"))
                    {
                        logo.Visible = false;
                        message.Visible = false;
                        messageToolStripMenuItem.Enabled = false;
                        label1.Text = "Categoria:" + " PERCURSO";
                        this.BackgroundImage = new Bitmap(@"C:\GitHub\TR\TR\Resources\back percur2.jpg");
                        label7.Location = new Point(114, 218);
                        label4.Visible = false;
                        label5.Visible = false;
                        l1.Visible = true;
                        l2.Visible = true;
                        l3.Visible = true;
                        l4.Visible = true;
                        l5.Visible = true;
                        l6.Visible = true;
                        l7.Visible = true;
                        l8.Visible = true;
                        l9.Visible = true;
                        l10.Visible = true;
                        label6.Visible = false;
                        label7.Visible = true;
                        label2.Location = new Point(318, 158);
                        label3.Visible = false;
                        if (cont > (eq.s.Length - 1))
                            cont--;
                        label2.Text = eq.s[cont];
                    }
                    else MessageBox.Show("Mude a chave!");
                }
            }
        }// deixa visivel tudo do percurso

        private void atualiza (string[] var)
        {
           
            cd.categoria = var[0]; // 0 para arrancada e 1 para percurso
            cd.temp_total_arrancada = var[1];
            cd.temp_entrada_lombada = var[2];
            cd.temp_saida_lombada = var[3];
            cd.temp_total_lombada = var[4];

            cd.temp_total_percurso = var[5];
            cd.temp_Marca1_ida =var[6];
            cd.temp_Marca2_ida = var[7];
            cd.temp_Marca3_ida = var[8];
            cd.temp_Volta1 = var[9];
            cd.temp_Marca3_volta = var[10];                        
            cd.temp_Marca2_volta = var[11];
            cd.temp_Marca1_volta = var[12];
            cd.temp_Volta2 = var[13];    
            


            label4.Text = "Início: " + var[2];
            label5.Text = "Fim: " + var[3];
            l3.Text = "MARCA 1:" + var[6];
            l4.Text = "MARCA 3:" + var[10];
            l5.Text = "MARCA 2:" + var[7];
            l6.Text = "MARCA 2:" + var[11];
            l7.Text = "MARCA 3:" + var[8];
            l8.Text = "MARCA 1:" + var[12];
            l9.Text = "VOLTA 1:" + var[9];
            l10.Text = "VOLTA 2:" + var[13];
            label6.Text = "Tempo Total: " + var[1];
            label3.Text = "Tempo Lombada: " + var[4];
            label7.Text = "Tempo Total: " + var[5];

        }  // atualiza os valores pegos da porta serial

        private void adicionarEquipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eq.ShowDialog();
        } // add equipes 

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ms.ShowDialog();
            message.Text = ms.s;
        }

        private void portasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        } // mensagem da pag inicial

    }
}