using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiggerEnter : MonoBehaviour {

	public GameObject mc;

	void Start () {
		Debug.Log ("Trigger Zone Loaded");
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("OnTriggerEnter");
		mc.transform.position = new Vector3 (6.58f + Random.value / 5f, 1f, 6.18f);
		Collider.Destroy (other);

		//Instantiate (go, new Vector3 (5.5f+Random.value/2f, 1f, 4.50f+Random.value/5f), Quaternion.identity);





	
	}

	void OnCollisionEnter(Collision other) {
		Debug.Log ("OnCollisionEnter");
	}

	void OnCollisionsStay(Collider other) {
		Debug.Log ("OnCollisionsStay");
	}

	void Update () {
		
	}
}
