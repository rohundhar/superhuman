var Speed : float;
var Turn : float; 

function Update (){
	Speed+=.5;
	Debug.Log("shooting missile...");
   	var targets: GameObject[] = GameObject.FindGameObjectsWithTag("Enemy");
    var closest: GameObject;
    var ClosestDist = Mathf.Infinity;

	    for (Target in targets){

    	var dist = (transform.position - Target.transform.position).sqrMagnitude;

   		if(dist < ClosestDist){
    		ClosestDist = dist;
    		closest = Target;

    	}

	}

 	transform.rotation=Quaternion.Slerp(transform.rotation,Quaternion.LookRotation(closest.transform.position-transform.position),Turn*Time.deltaTime);    
 	transform.position+=transform.forward*Speed*Time.deltaTime;

}
/*
function OnCollisionEnter(collision : Collision){
	Debug.Log("destroy missile");
	var prefab : GameObject = GameObject.FindWithTag("explode");
	var explosion = Instantiate (prefab) as GameObject;
		explosion.transform.position = transform.position;

		Destroy (explosion, 5);
		Destroy (gameObject);
    Destroy (gameObject);

} */