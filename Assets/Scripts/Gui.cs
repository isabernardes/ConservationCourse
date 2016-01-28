using UnityEngine;
using System.Collections;

public class Gui : MonoBehaviour {

private int time = 10; 
//public GameObject text;


	void Start () {
		StartCoroutine("GUI");

	}
	IEnumerator GUI()
	{
		yield return new WaitForSeconds(time);
		print("Ok");
		Destroy(gameObject);
	}

}





