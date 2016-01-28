using UnityEngine;
using System.Collections;

public class TransformPosition : MonoBehaviour {

	public GameObject cube;
	public Rigidbody rb;





	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "piece14") {
			print ("There's a collision");
			transform.localPosition = new Vector3 ( -0.008f, 0.854f, -0.047f);
			transform.localRotation = Quaternion.Euler(278.9936f, 322.6362f, 125.8113f);
			print (transform.localRotation.y);
			print (transform.localRotation.x);
			print (transform.localRotation.z);
			rb.isKinematic = true;
		}

	}
}

//transform.localPosition = new Vector3 ( -0.01479739f, 0.8481911f, -0.023f);
//transform.localRotation = Quaternion.Euler(-80.8195f, -47.800028f, 136.7008f);
