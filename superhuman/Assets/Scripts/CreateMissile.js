var projectile: GameObject;

function Start(){
}
function shoot_missile(){ 
	//if (Input.GetKeyDown(KeyCode.E)){ 
	//	Debug.Log("Missile Activated!");
		Instantiate(projectile,transform.position + Camera.main.transform.forward * 4, transform.rotation);
		
	//}
}
