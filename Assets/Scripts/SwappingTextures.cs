using UnityEngine;
using System.Collections;


public class SwappingTextures : MonoBehaviour {
	
	public Texture2D change;


	
	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.tag == "Player"){
			StartCoroutine(WaitTime(3));
			
		}
	}
	
	
	IEnumerator WaitTime(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		print("seconds up already");
		GetComponent<Renderer>().material.mainTexture = change;

	}
	
	
	
	
	
	
	
}