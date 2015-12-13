using UnityEngine;
using System.Collections;

public class ExplodingProjectile : MonoBehaviour {

//	private float timer = 0f;

	void Start () {
	
		Destroy (gameObject, 2);
	}

	void OnTriggerEnter (Collider collision) {
//		AddObjectsToPrefab ();
		GameObject prefab = Resources.Load ("ExplosionMobile") as GameObject;
		GameObject explosion = Instantiate (prefab) as GameObject;
		explosion.transform.position = transform.position;

		Destroy (explosion, 2);
	}
	/*
	static void AddObjectsToPrefab ()
	{	
		// Define the source
		string sourceName = "ExplosionMobile";	
		GameObject sourceGO = GameObject.Find (sourceName);
	
		// Some checks to try to ensure we don't use this method by mistake
		if (Selection.activeGameObject.activeInHierarchy) {
			Debug.Log ("Selection is within scene heirarchy. This function is only for Prefabs.");
			return;	
		}
		
		if (sourceGO == null) {
			Debug.Log (String.Format ("No object named {0} found in the current scene", sourceName));
			return;	
		}
	
		if (!EditorUtility.DisplayDialog ("Confirm copy", "Confirm you wish to copy objects from " + sourceName + 
			" to " + Selection.gameObjects.Length + " prefabs.", "Yes", "No") 
		    ) {
			Debug.Log ("Cancelled");	
			return;	
		}	
	
		// Define list of objects to copy from the source
		string[] goList = new string[] 
		{ 
		//"exclamation", 
		//"question", 
			"Mind",
			"Obstacle Avoidance Collider",
			"Path Manager",
			"Sensor"
		};
	
		List<GameObject> sourceObjects = new List<GameObject> ();	
	
		// get list of desired components from the source
		foreach (Transform child in sourceGO.transform) {
			for (int i=0; i < goList.Length; i++) {
				if (child.gameObject.name.Equals (goList)) {
					sourceObjects.Add (child.gameObject);
				}
			}
		}
	
		foreach (GameObject prefab in Selection.gameObjects) {
			// create an instance of the prefab
			GameObject prefabInstance = PrefabUtility.InstantiatePrefab (prefab) as GameObject;
		
			// clone the source objects and add to the prefab
			foreach (GameObject sourceObject in sourceObjects) {
				GameObject clone = Instantiate (sourceObject) as GameObject;	
				clone.transform.parent = prefabInstance.transform;
				clone.name = sourceObject.name; // gets rid of (clone) from the name
				clone.transform.localPosition = sourceObject.transform.localPosition;	
			}
		
			// apply the instance to the prefab
			PrefabUtility.ReplacePrefab (prefabInstance, PrefabUtility.GetPrefabParent (prefabInstance), ReplacePrefabOptions.ConnectToPrefab);	
		
			// remove the instance from the scene
			DestroyImmediate (prefabInstance);
		}
	}*/
}