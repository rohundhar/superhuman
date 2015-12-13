using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class CharacterRotating1 : MonoBehaviour
{
	[SerializeField]
	private Camera cam;
	
	[SerializeField]
	private Quaternion defaultAvatarRotation;
	
	[SerializeField]
	private float slowSpeedRotation = 0.03f;
	[SerializeField]
	private float speedRotation = 0.03f;
	
	private const string AVATAR_TAG = "avatar_model";
	
	private bool isRotating = false;
	
	private RaycastHit hit;
	
	void Awake()
	{
		Camera[] cameraList = FindObjectsOfType(typeof(Camera)) as Camera[];
		foreach (Camera camObj in cameraList)
		{
			if(camObj && camObj.tag == "Untagged")
			{
				cam = camObj;
			}
		}
		defaultAvatarRotation.y = 180.0f;
	}
	
	// Update is called once per frame
	void Update()
	{
		MouseButtonDown();
		MouseButotnUp();
		if (Input.GetMouseButton(0) && isRotating)
		{
			RaycastHit dragingHit;
			
			#if UNITY_EDITOR
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			#elif UNITY_ANDROID
			
			Ray ray = cam.ScreenPointToRay(Input.touches[0].position);
			#endif
			if(Physics.Raycast(ray, out dragingHit) && dragingHit.collider.gameObject == hit.collider.gameObject)
			{
				if(hit.collider.tag == AVATAR_TAG && transform == hit.collider.transform)
				{
					
					#if UNITY_EDITOR
					float x = -Input.GetAxis("Mouse X");
					#elif UNITY_ANDROID
					
					float x = -Input.touches[0].deltaPosition.x;
					#endif
					transform.rotation *= Quaternion.AngleAxis(x * speedRotation, Vector3.up);
				}
			}
		}
		else
		{
			if(transform.rotation.y != defaultAvatarRotation.y)
			{
				SlowRotation();
			}
		}
	}
	
	private void MouseButtonDown()
	{
		if(Input.GetMouseButtonDown(0))
		{
			
			#if UNITY_EDITOR
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			#elif UNITY_ANDROID
			Ray ray = cam.ScreenPointToRay(Input.touches[0].position);
			#endif
			if(Physics.Raycast(ray, out hit))
			{
				if(hit.collider.tag == AVATAR_TAG && transform == hit.collider.transform)
				{
					isRotating = true;
				}
			}
		}
	}
	
	private void MouseButotnUp()
	{
		if(Input.GetMouseButtonUp(0))
		{
			isRotating = false;
			hit = new RaycastHit();
		}
	}
	
	private void SlowRotation()
	{
		transform.rotation = Quaternion.Slerp(transform.rotation,
		                                      defaultAvatarRotation,
		                                      slowSpeedRotation * Time.deltaTime);
	}
}