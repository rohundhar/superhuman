using UnityEngine;
using System.Collections;

public class DestroyProjectile : MonoBehaviour {
	
	// Use this for initialization
	void OnEnable()
	{
		Invoke ("Destroy", 2f);
	}
	void Destroy(){
		gameObject.SetActive (false);
	}
	
	void OnDisable(){
		CancelInvoke ();
	}
	
}