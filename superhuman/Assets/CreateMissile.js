var projectile: GameObject;                                                     

function update(){ 
	if (Input.GetKeyDown(KeyCode.Tab)){ 
		Instantiate (projectile, transform.position, transform.rotation);
	}
}