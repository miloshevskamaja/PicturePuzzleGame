﻿using System;
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
    public partial class Form1 : System.Windows.Forms.Form
    {
        Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
          //  this.Show();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.SetDifficulty("easy");
            this.Hide();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2.SetDifficulty("medium");
            this.Hide();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form2.SetDifficulty("hard");
            this.Hide();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3=new Form3();
            form3.Show();
        }
    }
}
