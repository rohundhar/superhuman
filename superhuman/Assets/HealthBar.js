var barDisplay : float = 0;
var pos : Vector2 = new Vector2(20, 40);
var size : Vector2 = new Vector2(60, 40);
var progressBarEmpty : Texture2D;
var progressBarFull : Texture2D;

function OnGUI()
{
	GUI.BeginGroup(new Rect (pos.x, 10, 500, size.y));
	GUI.Box (Rect (0, 0, 450, size.y), progressBarEmpty);
	
	GUI.BeginGroup(new Rect (0, 0, 450 * barDisplay, size.y));
	GUI.Box (Rect (0, 0, 450, size.y), progressBarFull);
	GUI.EndGroup ();
	
	GUI.EndGroup();
}

function Update()
{
	barDisplay = 1 - Time.time * 0.005;
}