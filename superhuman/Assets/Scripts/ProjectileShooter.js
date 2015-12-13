#pragma strict

var prefab : GameObject;
private var projectile : GameObject;
private var rb : Rigidbody;

function Start () {
	prefab = Resources.Load("projectile");
}

function shoot () {
	projectile = Instantiate (prefab);
	projectile.transform.position = transform.position + Camera.main.transform.forward;
	rb = projectile.GetComponent(Rigidbody);
	rb.velocity = Camera.main.transform.forward * 30;
}