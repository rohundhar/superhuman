#pragma strict

var prefab : GameObject;
private var projectile : GameObject;
private var rb : Rigidbody;

function Start () {
}

function shoot () {
	projectile = Instantiate (prefab);
	projectile.transform.position = transform.position + Camera.main.transform.forward;
}