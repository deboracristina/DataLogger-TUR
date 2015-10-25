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
    public partial class message : Form
    {
        public message()
        {
            InitializeComponent();
        }
        public string s;
        private void button1_Click(object sender, EventArgs e)
        {
            s = textBox1.Text;
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { button1.PerformClick(); }
        }
    }
}
