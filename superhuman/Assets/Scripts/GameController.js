var gameOverText : GUIText;
static var gameOver : float = 1f;

function Start () {
}

function Update () {
	if (gameOver == 0) {
		gameOverText.text = "Game Over";
	}
}