using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {


	public GameObject prefab,prefab2;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var deviceIndex = SteamVR_Controller.GetDeviceIndex(SteamVR_Controller.DeviceRelation.Leftmost);
	
		if (SteamVR_Controller.Input (deviceIndex).GetHairTrigger ()) {
			Vector3 m = transform.position;
			SteamVR_Controller.Input (deviceIndex).TriggerHapticPulse (1000);

			Instantiate (prefab2, new Vector3 (m.x + Random.value - 0.5f, m.y + Random.value - 0.5f, m.z + Random.value - 1f), Quaternion.identity);
		}

		deviceIndex = SteamVR_Controller.GetDeviceIndex(SteamVR_Controller.DeviceRelation.Rightmost);


		if (SteamVR_Controller.Input(deviceIndex).GetHairTrigger ()) {

			Vector3 o = prefab.transform.position;
			SteamVR_Controller.Input (deviceIndex).TriggerHapticPulse (1000);

	//		GameObject pf = prefab;

			prefab.GetComponent<MeshRenderer>().sharedMaterial.SetColor("_Albedo", new Color (1f, 0f, 1f));
			prefab.GetComponent<MeshRenderer>().material.SetColor("_Albedo", new Color (1f, 0f, 1f));
			// GameObject go = Instantiate (prefab, new Vector3 (0.3f + Random.value * 2f, 27.5f, 4.59f), Quaternion.identity);
			GameObject go = Instantiate (prefab, new Vector3 (5.5f+Random.value/2f, 1f, 4.50f+Random.value/5f), Quaternion.identity);
			Transform t = go.GetComponent<Transform> ();
			//t.localScale.Set (.1f, .1f, .1f);

			Renderer r = go.GetComponent<Renderer>();
			r.material.color = new Color (Random.value, Random.value, Random.value);
			//go.GetComponent<MeshRenderer> ().material.SetColor ("_Albedo", new Color (1f, 0f, 1f));
			//Instantiate (prefab, new Vector3(o.x,o.y,o.z) , Quaternion.identity);
		}


	}
}
