using UnityEngine;
using System.Collections;

public class Glueing : MonoBehaviour {
	
	
	FixedJoint joint; 
	
	
	
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.W)) {
			Destroy (gameObject.GetComponent<FixedJoint>());
		}
	}
	
	void OnCollisionEnter(Collision c)
	{
		joint = gameObject.AddComponent<FixedJoint>();
		joint.connectedBody = c.rigidbody;
		
	}
	
	
}