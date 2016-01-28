using UnityEngine;
using System.Collections;

public class SleepOnAwake : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().Sleep();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
