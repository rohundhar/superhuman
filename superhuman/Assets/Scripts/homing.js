var Speed : float;
var Turn : float; 

function Update (){
	Speed+=.5;
   var targets: GameObject[] = GameObject.FindGameObjectsWithTag("Enemy");
   //var target : GameObject = GameObject.FindGameObjectWithTag("Enemy");
    var closest: GameObject;
    var ClosestDist = Mathf.Infinity;

	    for (Target in targets){

    	var dist = (transform.position - Target.transform.position).sqrMagnitude;//Target.transform.position).sqrMagnitude;

   		if(dist < ClosestDist){
    		ClosestDist = dist;
    		closest = Target;

    	}

	}

 	transform.rotation=Quaternion.Slerp(transform.rotation,Quaternion.LookRotation(closest.transform.position-transform.position),Turn*Time.deltaTime);    
 	transform.position+=transform.forward*Speed*Time.deltaTime;

}
