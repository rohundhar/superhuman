#pragma strict

	// Update is called once per frame
function Update () {
	if (GameObject.FindGameObjectWithTag("Enemy") == null){
		if (Application.loadedLevel == 1) {
			Application.LoadLevel ("Continue");
		}
	
		if (Application.loadedLevel == 4) {
			Application.LoadLevel ("Win");
		}
	}
}
