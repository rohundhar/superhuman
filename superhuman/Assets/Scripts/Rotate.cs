using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Rotate: MonoBehaviour {

	//private GameObject stickObject;
	private GameObject playerObject;
	private Transform playerTransform;
	//private Joystick script;
	private Touch initTouch = new Touch();
	public Camera cam;
	
	private float rotX = 0f;
	private float rotY = 0f;
	private Vector3 origRot; 
	
	public float rotSpeed = 0.5f;
	public float dir = -1;
	
	// Use this for initialization
	void Start () {
		//Debug.Log ("initialize swiping..");
		//stickObject = GameObject.FindGameObjectWithTag ("Joystick");
		//script = (Joystick)stickObject.GetComponent ("Joystick");
		origRot = cam.transform.eulerAngles;
		rotX = origRot.x;
		rotY = origRot.y;
		playerObject = GameObject.FindGameObjectWithTag ("Player");
		playerTransform = playerObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("In update function");
		foreach (Touch touch in Input.touches) {
			
			if (touch.phase == TouchPhase.Began){
				
				initTouch = touch;
				//Debug.Log ("touch has begun");
			}
			else if( touch.phase == TouchPhase.Moved && touch.position.x > Screen.width/2 && touch.position.y > (Screen.height/2) - 100){
				// swiping 
				//Debug.Log ("camera is moving..");
				float deltaX = initTouch.position.x - touch.position.x;
				float deltaY = initTouch.position.y - touch.position.y;
				rotX -= deltaY * Time.deltaTime * rotSpeed * dir;
				rotY += deltaX * Time.deltaTime * rotSpeed * dir;
				rotX = Mathf.Clamp(rotX,-45f,80f);
				cam.transform.eulerAngles = (new Vector3(rotX, rotY, 0f));
				playerTransform.eulerAngles = (new Vector3(rotX, rotY, 0f));

				//script.UpdateVirtualAxes(new Vector3(playerTransform.position.x, playerTransform.position.y, playerTransform.position.z));
			}
			else if(touch.phase == TouchPhase.Ended){
				
				initTouch = new Touch();
			}
			
			
		}
	}
}