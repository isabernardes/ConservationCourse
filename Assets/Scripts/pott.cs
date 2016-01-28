using UnityEngine;
using System.Collections;

public class pott : MonoBehaviour {

		
		public GameObject cube;
		public Rigidbody rb;
		
		
		
		
		
		void OnCollisionEnter(Collision collision){
			if (collision.gameObject.tag == "piece10") {
				print ("There's a collision");
				transform.localPosition = new Vector3 ( -0.164f, 0.032f, 0.02f);
			transform.localRotation = Quaternion.Euler(281.4473f, 316.3f, 135.9283f);
				print (transform.localRotation.y);
				print (transform.localRotation.x);
				print (transform.localRotation.z);
				rb.isKinematic = true;
			}
			
		}
	}
	
	//transform.localPosition = new Vector3 ( -0.01479739f, 0.8481911f, -0.023f);
	//transform.localRotation = Quaternion.Euler(-80.8195f, -47.800028f, 136.7008f);
