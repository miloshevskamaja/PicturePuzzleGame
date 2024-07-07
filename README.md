# PicturePuzzleGame

# 1. ***Опис на апликацијата Picture Puzzle Game***
   
   Оваа десктоп апликација ја направививме по класичниот концепт на играта за сложување на готова слика. Со цел играчот да има негов удел во самата игра, обезбедивме избор на неколку слики за сложување. Со тоа и 
   постои разлика во тежината на играта, бидејќи некои од сликите се за степен потешки за сложување од другите. Целта ни беше да направиме интерактивна и забавна игра која ќе ги соочи играчите да состават 	 
   различни парчиња од сликата на вистинското место, креирајќи интересна визуелна приказна.

# 2. ***Упатство за користење*** <br/>
   ## 2.1 ***Почеток на игра***

   Најпочетниот прозорец се состои од наслов и две копчиња кои означуваат Start и How to play. </br>
   
   При клик на **How to play** се појавува мало прозорче со текст на англиски јазик кој претставува упатство за играта.<br/>
   
   При клик на **Start**, играта започнува и се појавува прозорецот на кој имаме избор на слика.<br/>
   
   На прозорецот кој се појавува по клик на Start, имаме можност да одбериме една од 3те слики. Одбраната слика се вчитува во самата апликација, и е спремна за корисникот да ја сложува.
   Изборот на слика го дефинира нивото на тежина на играта. Направивме 3 нивоа, во зависност од одбраната слика, и тоа:
   
   **•	Hard <br/>
   •	Medium <br/>
   •	Easy**
   
![game1](https://github.com/miloshevskamaja/PicturePuzzleGame/assets/139159171/987a1fa7-1e70-4bb5-a45a-7b0d00849780)

![game2](https://github.com/miloshevskamaja/PicturePuzzleGame/assets/139159171/582679e2-a1fb-49ed-92d7-7c4fab8b65e1)



   ## 2.2 ***Сложување на одбрана слика***

   После самиот избор на одредена слика, истата се вчитува на апликацискиот прозорец со тоа што:<br/>
   •	На левата страна се наоѓа оригиналната слика </br>
   
   •	На десната страна се наоѓаат 9те еднакви парчиња од оригиналната слика (8+1 црна слика која означува празно место за движење на сликите)<br/>
   
   Оригиналната слика им помага на играчите да знаат како треба да изгледа сложената слика. <br/>
   Секое делче од сликата наменето за сложување е претставено со '_PictureBox_'

   ![game3](https://github.com/miloshevskamaja/PicturePuzzleGame/assets/139159171/953447cd-51e3-45dd-8c55-eeac37d331ca)


   ## 2.3 ***Функционалности***

   Под самата оригинална слика се наоѓаат некои дополнителни функционалности на играта, со цел да обезбедиме комплетно задоволство кај играчот.</br>
   
   Постои тајмер (**Timer**) кој го мери времето на играчот ОТКАКО ќе започне да ја игра играта. Па така, при клик на некое од делчињата од сликата, тајмерот почнува да брои, а тоа се прикажува на екранот со цел играчот да има претстава колку време му останува. Лимитот за решавање на сложувалката е 1 минута. По истеченото време, се појавува прозорец кој покажува дека обидот е неуспешен, и порака за играчот да се обиде повторно.<br/>

   Овде постои опција за паузирање (**Pause**), опција за менување на редоследот на делчињата (**Shuffle**), како и опција за откажување (**Quit**). <br/>

   При клик на **Pause**: играта која веќе ја започнал играчот се паузира, со тоа што деловите од сложувалката постануваат невидливи и играчот нема можност да манипулира со истите. Исто така тајмерот се стопира сѐ додека не се кликне на Resume. Копчето **Resume** се појавува на истото место каде што било Pause, откако ќе се кликне на Pause.<br/>

   При клик  на **Shuffle**: деловите за сложување на сликата го менуваат својот распоред. Така, доколку се кликне Shuffle додека играчот ја сложува сложувалката, тоа позадински се смета за **RESTART** на самата игра и се појавува прозорец за согласност. Доколку корисникот одбере YES започнатата игра прекинува, тајмерот се ресетира и започнува нова игра, со нов распоред на деловите од сложувалката

   При клик  на **Quit**: се појавува прозорец за согласност, дали играчот е сигурен дека сака да ја исклучи веќе започнатата игра. Доколку играчот кликне YES, играта е прекината и апликацијата се исклучува.

   Покрај овие копчиња (функционалности), постои и една лабела под деловите од сложувалката во која се прикажуваат сите направени потези  (**Made Moves**). Преку неа се бројат сите потези на играчот додека ја сложува сложувалката, т.е. колку пати ќе помести делче. Се чува промелнива која се инкрементира при секој нов потег на играчот. Тоа се прикажува на крајот од играта, во прозорец кој се појавува доколку сложувалката е успешно сложена. 

 # 3. ***Имплементација***

   Играта ја имплементиравме преку креирање на 3 форми и неколку функции за манипулација со истите. За дизајн користевме готови позадински слики, интересен фонт и разни бои со цел поголема визуеална 
   привлечност кај играчот. 

   ## 3.1 ***Ресурси***

   Сите ресурси кои ги користевме за играта, т.е. самите оригинални слики, деловите на истите тие слики, како и сликите за дизајн на апликацијата ги чуваме во фолдер  **Resources**. За прикажување на тие слики 
   пристапувавме преку тој фолдер. Во прилог е дел од кодот кој го имплементиравме за да се прикаже оригиналната слика, како и нејзините делови на играта доколку се одбере ниво MEDIUM.

   ```ruby
   if (difficulty == "medium")
   {
   	gbOriginal.BackgroundImage = Properties.Resources.original;
    	OriginalPictureList.AddRange(new Bitmap[] { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3, Properties.Resources._4, Properties.Resources._5, 				 
            Properties.Resources._6,Properties.Resources._7, Properties.Resources._8, Properties.Resources._9, Properties.Resources._null });
   }
   ```

   ## 3.2 ***Победа***

   Доколку играчот ја сложи сложувалката, играта се прекинува покажувајќи се прозорец кој дава информација за времето и потезите.
   Со цел играта успешно да ја прикаже победата на играчот, имаме имплементирано функција **CheckWin()** со која проверуваме дали споените делчиња се вклопуваат со секое делче од оригиналната слика. Во 
   продолжение е даден тој код:

   ```ruby

   bool CheckWin()
   {
    	int i;
    	for (i = 0; i < 8; i++)
    	{
            if ((gbPuzzleBox.Controls[i] as PictureBox).Image != OriginalPictureList[i])
	        break;
   	}
    	if (i == 8)
    	{
		return true;
    	}
    	else return false;
   }

   ```
   Оваа функција ја користиме во друга функција со име **SwitchPictureBox()**, која се повикува со секој клик на делче од сликата. Покрај останатиот дел од кодот за оваа функција (кој може да се види во кодот на 
   апликацијата), во прилог е даден кодот кој е имплементиран за тоа како треба да се однесува апликацијата при победа на играчот:

   ```ruby

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

   ```
   ## 3.3 ***Тајмер***

   Како што веќе споменавме, играта има тајмер од 1 минута за решавање на оваа сложувалка. По изминување на ова предвидено време, играта сама се стопира и прикажува порака за да се извести играчот дека времето е 
   истечено, и порака за  нов обид. Во продолжение е кодот од функцијата **UpdateTimeElapsed()**:
   

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

# 4. ***За играта*** 

  Играта е визуелно привлечна со светли и шарени слики кои ја стимулираат вашата креативност и логичко размислување.
  <br/>
  Се надеваме дека ќе уживате играјќи ја _Picture Puzzle Game_.

  ## Изработка: <br/>
  
  -Маја Милошевска (221095) <br/>
  -Константина Михаилова (221107)




