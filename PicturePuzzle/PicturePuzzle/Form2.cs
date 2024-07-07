using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PicturePuzzle
{
    public partial class Form2 : System.Windows.Forms.Form
    {

        public bool easy = false;
        public bool medium = false;
        public bool hard = false;


        private string difficulty;
        int nullPicture, numOfMoves = 0;
        List<Bitmap> OriginalPictureList = new List<Bitmap>();
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

        public Form2()
        {
            this.Hide();
            InitializeComponent();
            lblTimeElapsed.Text = "00:00:00";
            lblMovesMade.Text += numOfMoves;
           // OriginalPictureList.AddRange(new Bitmap[] { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3, Properties.Resources._4, Properties.Resources._5, Properties.Resources._6, Properties.Resources._7, Properties.Resources._8, Properties.Resources._9, Properties.Resources._null });
        }
        public void SetDifficulty(string difficulty)
        {
            this.difficulty = difficulty;
        }




        private void Form2_Load(object sender, EventArgs e)
        {
           // ShufflePictures();
            this.Shown += new System.EventHandler(this.Form2_Shown);
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
            int i;
            for (i = 0; i < 8; i++)
            {
                if ((gbPuzzleBox.Controls[i] as PictureBox).Image != OriginalPictureList[i]) break;
            }
            if (i == 8)
            {
                return true;
            }
            else return false;
        }


        private void btnShuffle_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNo = new DialogResult();
            if (lblTimeElapsed.Text != "00:00:00")
            {
                YesOrNo = MessageBox.Show("Are you sure you want to RESTART the game?", "Picture Puzzle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (YesOrNo == DialogResult.Yes || lblTimeElapsed.Text == "00:00:00")
            {
                ShufflePictures();
                timer.Reset();
                lblTimeElapsed.Text = "00:00:00";
                numOfMoves = 0;
                lblMovesMade.Text = "Moves Made : 0";
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            AskPermissionBeforeQuite(sender, e as FormClosingEventArgs);
        }


        private void PauseOrResume(object sender, EventArgs e)
        {
            if (btnPause.Text == "Pause")
            {
                timer.Stop();
                gbPuzzleBox.Visible = false;
                btnPause.Text = "Resume";
            }
            else
            {
                timer.Start();
                gbPuzzleBox.Visible = true;
                btnPause.Text = "Pause";
            }
        }

        private void UpdateTimeElapsed(object sender, EventArgs e)
        {
            if (timer.Elapsed.ToString() != "00:00:00")
                lblTimeElapsed.Text = timer.Elapsed.ToString().Remove(8);
            if (timer.Elapsed.ToString() == "00:00:00")
                btnPause.Enabled = false;
            else
                btnPause.Enabled = true;
            if (timer.Elapsed.Minutes.ToString() == "1")
            {
                timer.Reset();
                lblMovesMade.Text = "Moves Made : 0";
                lblTimeElapsed.Text = "00:00:00";
                numOfMoves = 0;
                btnPause.Enabled = false;
                MessageBox.Show("Time Is Up. Try Again", "Picture Puzzle");
                ShufflePictures();
            }
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            OriginalPictureList.Clear();
            if (difficulty == "easy")
            {
                gbOriginal.BackgroundImage = Properties.Resources.dogPicture;
                OriginalPictureList.AddRange(new Bitmap[] { Properties.Resources._11, Properties.Resources._12, Properties.Resources._13, Properties.Resources._14, Properties.Resources._15, Properties.Resources._16, Properties.Resources._17, Properties.Resources._18, Properties.Resources._19, Properties.Resources._null });
            }
            else if (difficulty == "medium")
            {
                gbOriginal.BackgroundImage = Properties.Resources.original;
                OriginalPictureList.AddRange(new Bitmap[] { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3, Properties.Resources._4, Properties.Resources._5, Properties.Resources._6, Properties.Resources._7, Properties.Resources._8, Properties.Resources._9, Properties.Resources._null });
            }
            else if (difficulty == "hard")
            {
                gbOriginal.BackgroundImage = Properties.Resources.tigerPicture;
                OriginalPictureList.AddRange(new Bitmap[] { Properties.Resources._21, Properties.Resources._22, Properties.Resources._23, Properties.Resources._24, Properties.Resources._25, Properties.Resources._26, Properties.Resources._27, Properties.Resources._28, Properties.Resources._29, Properties.Resources._null });
            }

            ShufflePictures();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form=new Form1();
            form.Show();
        }

        private void AskPermissionBeforeQuite(object sender, FormClosingEventArgs e)
        {
            DialogResult YesOrNO = MessageBox.Show("Are you sure you want to QUIT the game?", "Picture Puzzle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sender as Button != btnQuit && YesOrNO == DialogResult.No) e.Cancel = true;
            if (sender as Button == btnQuit && YesOrNO == DialogResult.Yes) Environment.Exit(0);
        }


      


    }


}
