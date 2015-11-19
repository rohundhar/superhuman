var projectile: GameObject;

function Start(){
	Debug.Log("In Start function...");

}
function Update(){ 
	if (Input.GetKeyDown(KeyCode.E)){ 
		Debug.Log("Missile Activated!");
		Instantiate(projectile,transform.position + Camera.main.transform.forward * 4, transform.rotation);
		
	}
}
