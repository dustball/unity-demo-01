using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMaker : MonoBehaviour {

	public GameObject prefab;
	int i;

	void Start()
	{
		i = 0;
	}
	
	// Update is called once per frame
	void Update () {

		i = i + 1;

		if (i > 5) {
			
			Vector3 o = prefab.transform.position;


			// Instantiate (prefab, new Vector3 (o.x + Random.value * 2f, 27.5f, o.z), Quaternion.identity);
			i = 0;
		}
		
	}
}
