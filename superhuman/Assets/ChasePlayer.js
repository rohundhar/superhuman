var target : Transform; 
var moveSpeed = 3; 
var rotationSpeed = 3; 
var myTransform : Transform; 
var playerObject : GameObject;
var playerPosition : Vector3;

function Awake(){ 
	myTransform = transform; 
}

function Start(){ 
	playerObject = GameObject.FindWithTag("Player");
	playerPosition = playerObject.transform.position;
	target = GameObject.FindWithTag("Player").transform; 
}

function Update () { 
	var lookDir = target.position - myTransform.position; 
	lookDir.y = 0; // zero the height difference 
	myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(lookDir), rotationSpeed*Time.deltaTime); 
	myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
	playerPosition = playerObject.transform.position;
}
