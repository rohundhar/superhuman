using UnityEngine;
using System.Collections;

public class ButtonLogic : MonoBehaviour {

	// Use this for initialization
	public void Begin_change() {
		Application.LoadLevel ("Level1Orb");
	}

	public void Instructions_change() {
		Application.LoadLevel ("Instructions");
	}

	public void Story_change() {
		Application.LoadLevel ("Story");
	}

	public void Main_change() {
		Application.LoadLevel ("Main_menu");
	}

	public void Continue_change() {
		Application.LoadLevel ("Level2Orb");
	}

	public void Game_over() {
		Application.LoadLevel ("GameOver");
	}

	public void Lvl2() {
		Application.LoadLevel ("Level2Orb");
	}
}
