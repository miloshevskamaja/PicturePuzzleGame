# PicturePuzzleGame


```ruby
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
```


