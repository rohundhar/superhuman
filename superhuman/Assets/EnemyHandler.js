var enemySpeed : float = 2.5f;
// we can adjust his speed later to fit the game's needs.
var isChasing : boolean = false;
//animation["creature1walkforward"].wrapMode = WrapMode.Loop; 
var anim : Animator;
var target : Transform; 
var moveSpeed = 3; 
var rotationSpeed = 3; 
var myTransform : Transform; 
var playerObject : GameObject;
var playerPosition : Vector3;

function Awake(){ 
	myTransform = transform; 
}

function start() {
	anim = GetComponent("Animator");
	playerObject = GameObject.FindWithTag("Player");
	playerPosition = playerObject.transform.position;
	target = playerObject.transform; 
}


function Update(){ 
	anim.SetBool("Spawn", true);
	var lookDir = target.position - myTransform.position; 
	lookDir.y = 0; // zero the height difference 
	myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(lookDir), rotationSpeed*Time.deltaTime); 
	myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
	playerPosition = playerObject.transform.position; 

} 