# PicturePuzzleGame

#1. ***Опис на апликацијата Picture Puzzle Game***
   
   Оваа десктоп апликација ја направививме по класичниот концепт на играта за сложување на готова слика. Со цел      играчот да има негов удел во самата игра, обезбедивме избор на неколку слики за сложување.Со тоа и постои     
   разлика во тежината на играта, бидејќи некои од сликите се за степен потешки за сложување од другите.  Целта 
   ни беше да направиме интерактивна и забавна игра која ќе ги соочи играчите да состават различни парчиња од 
   сликата на вистинското место, креирајќи интересна визуелна приказна.

#2. ***Упатство за користење*** <br/>
   ##2.1 ***Почеток на игра***

    Најпочетниот прозорец се состои од наслов и две копчиња кои означуваат Start и How to play. 
   При клик на **How to play** се појавува мало прозорче со текст на англиски јазик кој претставува упатство за      играта.
   При клик на **Start**, играта започнува и се пјавува прозорецот на кој имаме избор на слика.
   На прозорецот  кој се појавува по клик на Start,  имаме можност да одбериме една од 3те слики. Одбраната слика    се вчитува во самата апликација, и е спремна за корисникот да ја сложува.
   Изборот на слика го дефинира нивото на тежина на играта. Направивме 3 нивоа, во зависност од одбраната слика,     и тоа:
   
   **•	Hard <br/>
   •	Medium <br/>
   •	Easy**

![Screenshot 2024-07-07 185704](https://github.com/miloshevskamaja/PicturePuzzleGame/assets/139159171/9dea9808-373f-4f84-813f-96cdc6e51cb8)



   

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


