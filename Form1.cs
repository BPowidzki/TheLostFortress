using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheLostFortress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Room r = new Room();
            r.name = "Troll Room";
            r.n = 1;
            r.s = 2;
            r.w = 3;
            r.e = 4;
            outputTB.Text =  $"You are in the {r.name} There are exits to: ";
        }
    }
}
