using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TR
{
    public partial class equipes : Form
    {
        public equipes()
        {
            InitializeComponent();
        }

        public string[] s;
        public int line;

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Lines.Length != 0)
            {
                line = richTextBox1.Lines.Length;
                s = new string[line];
                for (int j = 0; j < line; j++)
                    s[j] = "" + 0;
                for (int i = 0; i < line; i++)
                {
                    s[i] = richTextBox1.Lines[i];
                }
                this.Close();
            }
            else MessageBox.Show("Inscreva alguma equipe!");
        }
    }
}
