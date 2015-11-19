using UnityEngine;
using System.Collections;

public class ExplodingProjectile : MonoBehaviour {
	
	void Start () {
	
	}

	void OnCollisionEnter (Collision collision) {
		GameObject prefab = Resources.Load ("ExplosionMobile") as GameObject;
		GameObject explosion = Instantiate (prefab) as GameObject;
		explosion.transform.position = transform.position;

		Destroy (explosion, 5);
		Destroy (gameObject);
	}
}
