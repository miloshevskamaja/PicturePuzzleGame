using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicturePuzzle
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form=new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Picture Puzzle Game starts when you click the START button. Then, you should choose the picture you want to solve. The game has three difficulty levels: easy, medium, and hard. Once you have chosen the level, you will be directed to a new window where you will see the original picture on the left and the pieces of the picture on the right. Once you click on a piece, the timer starts. Each piece can move up, down, left, or right depending on the position of the black piece. You have 60 seconds to solve the puzzle. You can pause the game or shuffle the pieces if you want. The game also counts the moves you make. When you solve the puzzle, the game will inform you of the time and the number of moves you took to solve it. If the timer runs out, the game ends.", "How to play");

        }
    }
}
