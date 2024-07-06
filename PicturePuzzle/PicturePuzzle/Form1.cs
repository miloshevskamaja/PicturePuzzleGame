﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PicturePuzzle
{
    public partial class Form1 : Form
    {

        int nullPicture, numOfMoves = 0;
        List<Bitmap> OriginalPictureList = new List<Bitmap>();
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

        public Form1()
        {
            InitializeComponent();
            lblTimeElapsed.Text = "00:00:00";
            lblMovesMade.Text += numOfMoves;
            OriginalPictureList.AddRange(new Bitmap[] { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3, Properties.Resources._4, Properties.Resources._5, Properties.Resources._6, Properties.Resources._7, Properties.Resources._8, Properties.Resources._9, Properties.Resources._null });
          
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShufflePictures();
        }

        void ShufflePictures()
        {
            do
            {
                int j;
                List<int> indexesOfPictures = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 });//8 is not present - since it is the last slice.
                Random r = new Random();
                for (int i = 0; i < 9; i++)
                {
                    indexesOfPictures.Remove((j = indexesOfPictures[r.Next(0, indexesOfPictures.Count)]));
                    ((PictureBox)gbPuzzleBox.Controls[i]).Image = OriginalPictureList[j];
                    if (j == 9)
                    {
                        nullPicture = i;
                    }
                }
            } while (CheckWin());
        }

     


        private void SwitchPictureBox(object sender, EventArgs e)
        {
            if (lblTimeElapsed.Text == "00:00:00")
            {
                timer.Start();
               // Console.WriteLine("started");
            }

            int pictureBoxIndex = gbPuzzleBox.Controls.IndexOf(sender as Control);
            if (nullPicture != pictureBoxIndex)
            {

                List<int> list = new List<int>();

                // Check if the move to the left is valid
                if (pictureBoxIndex % 3 == 0)
                {
                    list.Add(-1);
                }
                else
                {
                    list.Add(pictureBoxIndex - 1);
                }

                // Move up
                list.Add(pictureBoxIndex - 3);

                // Check if the move to the right is valid
                if (pictureBoxIndex % 3 == 2)
                {
                    list.Add(-1);
                }
                else
                {
                    list.Add(pictureBoxIndex + 1);
                }

                // Move down
                list.Add(pictureBoxIndex + 3);



                if (list.Contains(nullPicture))
                {
                    ((PictureBox)gbPuzzleBox.Controls[nullPicture]).Image = ((PictureBox)gbPuzzleBox.Controls[pictureBoxIndex]).Image;
                    ((PictureBox)gbPuzzleBox.Controls[pictureBoxIndex]).Image = OriginalPictureList[9];
                    nullPicture = pictureBoxIndex;

                    lblMovesMade.Text = "Moves Made : " + (++numOfMoves);

                    if (CheckWin())
                    {
                        timer.Stop();
                        (gbPuzzleBox.Controls[8] as PictureBox).Image = OriginalPictureList[8];
                        MessageBox.Show("CONGRATULATIONS !!! \nTime Elapsed : " + timer.Elapsed.ToString().Remove(8) + "\nTotal Moves Made : " + numOfMoves, "Picture Puzzle Game");
                        numOfMoves = 0;
                        lblMovesMade.Text = "Moves Made : 0";
                        lblTimeElapsed.Text = "00:00:00";
                        timer.Reset();
                        ShufflePictures();
                    }
                }
            }
        }

        bool CheckWin()
        {
            return false;
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
        
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {

        }

        private void PauseOrResume(object sender, EventArgs e)
        { 

        }

        private void UpdateTimeElapsed(object sender, EventArgs e)
        {

        }



        }
   
    
}