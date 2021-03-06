﻿ var barDisplay : float = 1;
 var pos : Vector2 = new Vector2(20,40);
 var size : Vector2 = new Vector2(60,20);
 var progressBarEmpty : Texture2D;
 var progressBarFull : Texture2D;
 static var health : float = 1;
 
 function OnGUI()
 {
 
     // draw the background:
     GUI.BeginGroup (new Rect (pos.x, pos.y, 500, 100));
         GUI.Box (Rect (0,0, 500, 100),progressBarEmpty);
 
         // draw the filled-in part:
         GUI.BeginGroup (new Rect (0, 0, 500 * barDisplay, 100));
             GUI.Box (Rect (0,0, 500, 100),progressBarFull);
         GUI.EndGroup ();
 
     GUI.EndGroup ();
 
 } 
 
 function Update()
 {
     // for this example, the bar display is linked to the current time,
     // however you would set this value based on your desired display
     // eg, the loading progress, the player's health, or whatever.
     barDisplay = health;
     if (health < 0) {
     	health = 1;
     	Application.LoadLevel("Died");
     }
     
 }