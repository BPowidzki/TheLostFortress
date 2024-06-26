using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheLostFortress.gameClasses;
using static TheLostFortress.gameClasses.Player;

namespace TheLostFortress
{
    public partial class Form1 : Form
    {
        Adventure adv; //The Adventure object
       
            public Form1()
            {
                InitializeComponent();
                InitGame();
                StartGame();
            }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitGame()
        {
            adv = new Adventure();
        }
            private void StartGame()
            {
                outputTB.Text = $"Welcome to the Great Adventure!!! \r\nYou are in the {adv.Player.Location.Name}. It is {adv.Player.Location.Description}\r\n";
                outputTB.AppendText("Where do you wish to go?\r\n");
                outputTB.AppendText("Click a one of the direction button: N, S, W, E\r\n\r\n");
                outputTB.AppendText("To view current room description click\"Look\" button\r\n");
            }


        private void LookBtn_Click(object sender, EventArgs e)
        {
         outputTB.Text = $"You are in the {adv.Player.Location.Name}\r\n It is {adv.Player.Location.Description}\r\n";

        }
        
        private void MovePlayer(Dir direction)
        {
            outputTB.Text = adv.MovePlayerTo(direction);
        }

        private void NBtn_Click(object sender, EventArgs e)
        {
            MovePlayer(Dir.NORTH);
        }

        private void SBtn_Click(object sender, EventArgs e)
        {
            MovePlayer(Dir.SOUTH);
        }

        private void EBtn_Click(object sender, EventArgs e)
        {
            MovePlayer(Dir.EAST);
        }

        private void WBtn_Click(object sender, EventArgs e)
        {
            MovePlayer(Dir.WEST);
        }
    }
}