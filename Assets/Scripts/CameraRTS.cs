using UnityEngine;
using System.Collections;

public class CameraRTS : MonoBehaviour {
	
	
	
	[System.Serializable]
	public class PositionSettings
	{
		public bool invertPan = true;
		public float panSmooth = 7f;
		public float distanceFromGround = 40;
		//		public bool allowZoom = true;
		//		public float zoomSmooth = 5;
		//		public float zoomStep = 5;
		//		public float maxZoom = 80;
		//		public float minZoom = 25;
		
		
		[HideInInspector]
		public float newDistance = 40;
	}
	
	
	
	[System.Serializable]
	public class OrbitSettings
	{
		public float xRotation = 50;
		public float yRotation = 0;
		public bool allowYOrbit = true;
		public float yOrbitSmooth = 0.5f;
	}
	
	[System.Serializable]
	public class InputSettings
	{
		public string PAN = "MousePan";
		public string ORBIT_Y = "MouseTurn";
		public string ZOOM = "Mouse ScrollWheel";
		
	}
	
	public PositionSettings position = new PositionSettings();
	public OrbitSettings orbit = new OrbitSettings();
	public InputSettings input = new InputSettings ();
	
	Vector3 destination = Vector3.zero;
	Vector3 camVel = Vector3.zero;
	Vector3 previousMousePos = Vector3.zero;
	Vector3 currentMousePos = Vector3.zero;
	float panInput, orbitInput, zoomInput;
	int panDirection = 0;
	
	
	void Start ()
	{
		panInput = 0;
		orbitInput = 0;
		zoomInput = 0;
	}
	
	void GetInput()
	{
		panInput = Input.GetAxis (input.PAN);
		orbitInput = Input.GetAxis (input.ORBIT_Y);
		zoomInput = Input.GetAxis (input.ZOOM);
		
		previousMousePos = currentMousePos;
		currentMousePos = Input.mousePosition;
	}
	
	void Update ()
	{
		GetInput ();
		Zoom ();
		
		PanWorld ();
		
	}
	
	
	//		Rotate ();
	
	
	
	
	void PanWorld() {
		
		
		Vector3 targetPos = transform.position;
		
		if (position.invertPan)
			panDirection = -1;
		else
			panDirection = 1;
		
		if (panInput > 0) {
			targetPos += transform.right * (currentMousePos.x - previousMousePos.x) * position.panSmooth * panDirection * Time.deltaTime;
			targetPos += Vector3.Cross (transform.right, Vector3.up) * (currentMousePos.y - previousMousePos.y) * panDirection * Time.deltaTime;
			
		}
		
		transform.position = targetPos;
		
	}
	
	
	
	void Zoom ()
	{
		
		// Code for Zooming Out
		if (Input.GetAxis("Mouse ScrollWheel") < 0)
		{
			if (Camera.main.fieldOfView<=125)
				Camera.main.fieldOfView +=2;
			if (Camera.main.orthographicSize<=20)
				Camera.main.orthographicSize +=0.5f;
			
		}
		// Code for Zooming In
		if (Input.GetAxis("Mouse ScrollWheel") > 0)
		{
			if (Camera.main.fieldOfView>2)
				Camera.main.fieldOfView -=2;
			if (Camera.main.orthographicSize>=1)
				Camera.main.orthographicSize -=0.5f;
		}
		
		
		
	}
	
	//	void Rotate ()
	//	{
	//
	//
	//
	//
	//
	////		if (orbitInput < 0) {
	////			orbit.yRotation += (currentMousePos.x - previousMousePos.x) * orbit.yOrbitSmooth * Time.deltaTime;
	////		}
	////		
	////		transform.rotation = Quaternion.Euler (orbit.xRotation, orbit.yRotation, 0);
	//		
	//		
	//	}
	
	
}