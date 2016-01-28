using UnityEngine;
using System.Collections;

public class pott2 : MonoBehaviour {
	
	
	public GameObject cube;
	public Rigidbody rb;
	
	
	
	
	
	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "piece8") {
			print ("There's a collision");
			transform.localPosition = new Vector3 ( -0.028f, 0.371f, -0.166f);
			transform.localRotation = Quaternion.Euler(279.7291f, 305.0316f, 146.8898f);
			print (transform.localRotation.y);
			print (transform.localRotation.x);
			print (transform.localRotation.z);
			rb.isKinematic = true;
		}
		
	}
}