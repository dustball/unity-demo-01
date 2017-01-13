using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonUp : MonoBehaviour {

	private Rigidbody r;
	public Transform go;

	// Use this for initialization
	void Start () {
		r = GetComponent<Rigidbody> ();
		go = GetComponent<Transform> ();

	}

	// Update is called once per frame
	void Update () {


		Vector3 o = r.position;
		if (o.x > 5.76f && o.y<26.5f) {
			o.y += .7f;
			go.position = o;

			//ball.transform.position = o;
			//r.AddForce(0f,150.2f,0f);
			//ball.AddForce(4ew Vector3(0,3f,0));
			//ball.AddRelativeForce (new Vector3 (0, 10f, 0));
		}
		if (o.x > 4.75f && o.y>=27f) {
			o.x -= .7f;
			go.position = o;

			//ball.transform.position = o;
			//r.AddForce (-13.5f, 0f, 0f);
			//ball.AddForce(new Vector3(0,3f,0));
			//ball.AddRelativeForce (new Vector3 (0, 10f, 0));
		}

	}
}
