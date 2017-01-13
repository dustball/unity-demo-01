using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class Mover: MonoBehaviour
{
    public float speed;
    public float tilt;
    public Boundary boundary;

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

		Rigidbody rigidbody = GetComponent<Rigidbody> ();



		Vector3 movement;


		int deviceIndex = SteamVR_Controller.GetDeviceIndex(SteamVR_Controller.DeviceRelation.Rightmost);

		if (SteamVR_Controller.Input (deviceIndex).GetHairTrigger ()) {
			Vector2 v2 = SteamVR_Controller.Input (deviceIndex).GetAxis (Valve.VR.EVRButtonId.k_EButton_Axis0);
			moveVertical = v2.x;
			moveHorizontal = -v2.y;

		}
		movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);


        rigidbody.velocity = movement * speed;

        rigidbody.position = new Vector3 
        (
            Mathf.Clamp (rigidbody.position.x, boundary.xMin, boundary.xMax), 
            0.0f, 
            Mathf.Clamp (rigidbody.position.z, boundary.zMin, boundary.zMax)
        );

        rigidbody.rotation = Quaternion.Euler (0.0f, 0.0f, rigidbody.velocity.x * -tilt);
    }

}


