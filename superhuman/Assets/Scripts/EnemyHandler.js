var anim : Animator;
var target : Transform; 
var moveSpeed = 3; 
var playerObject : GameObject;
var playerPosition : Vector3;
var controller : CharacterController;
var distance : float = 0f;
var baddieHealth : float = 1f;

function start() {
	anim = GetComponent("Animator");
	playerObject = GameObject.FindWithTag("Player");
	playerPosition = playerObject.transform.position;
	target = playerObject.transform;
	controller = gameObject.GetComponent(CharacterController);
	distance = Vector3.Distance(transform.position, target.position);
}

function Update(){ 
	if (baddieHealth <= 0) {
		anim.SetTrigger("Dead");
		Destroy(gameObject, 1.2);
	}
	anim.SetBool("Spawn", true);
	distance = Vector3.Distance(transform.position, target.position);
	anim.SetFloat("AttackDist", distance);
	if (distance < 3) {
		anim.SetBool("HasAttacked", true);
		//Health.health = Health.health - .005;
	}

	transform.LookAt(Vector3(target.position.x, transform.position.y, target.position.z));
	controller.SimpleMove(moveSpeed * transform.forward);
} 

function OnTriggerEnter (hit : Collider) {
     if (hit.gameObject.tag == "Projectile") {
		baddieHealth = baddieHealth - 1;
     }
}