using UnityEngine;
using System.Collections;

public class Particle : MonoBehaviour {
	
	public ParticleSystem Particles;
	
	void Start (){
		Particles.enableEmission = false;
		
	}
	
	
	
	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "Player"){
			print("There's a collision");
			Particles.enableEmission = true;
			Particles.Play ();
		}
	}
}
