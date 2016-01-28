using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	
	public float turnSpeed = 4.0f;
	
	public Transform target;
	
	private Vector3 offset;
	
	void Start ()
	{
		offset = transform.position - target.position;
		transform.LookAt (target.position);
	}
	
	void LateUpdate()
	{
		if (Input.GetMouseButton (1)) {
			offset = Quaternion.AngleAxis (Input.GetAxis ("Mouse X") * turnSpeed, Vector3.up) * offset;
			transform.position = target.position + offset;
			transform.LookAt (target.position);
		}
		
		
		
	}
}

