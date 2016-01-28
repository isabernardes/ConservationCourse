using UnityEngine;
using System.Collections;

public class pot9 : MonoBehaviour {

	public GameObject cube;
	public Rigidbody rb;
	
	
	
	
	
	
	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "piece10") {
			print ("There's a collision");
			transform.localPosition = new Vector3 ( -0.021f, 0.369f, -0.165f);
			transform.localRotation = Quaternion.Euler(-83.56291f, -344.7896f, 102.6607f);
			print (transform.localPosition.y);
			rb.isKinematic = true;
		}
		
	}
}