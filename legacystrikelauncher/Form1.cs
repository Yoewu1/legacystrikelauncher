using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace legacystrikelauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "doload")
            {
                MessageBox.Show("doload completino");
                button1.Text = "lacun";
            }
            else
            {
                string lavak = textBox1.Text;

                if (lavak == "-lavak")
                {
                    MessageBox.Show("lavak sikmis btw kekw lmao lol daha once duydun mu sanmiyorum .d");
                }
                else
                {
                    MessageBox.Show("nigerino lacun has been injected into your nt kernel");
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }
    }
}
