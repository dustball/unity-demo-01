using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMan : MonoBehaviour {

	public GameObject g;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = g.transform.position;
		transform.rotation = g.transform.rotation;
		
	}
}
