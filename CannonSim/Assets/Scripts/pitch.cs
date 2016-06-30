using UnityEngine;
using System.Collections;

public class pitch : MonoBehaviour {

	// The maximum and the minimum pitch the cannon can be positioned.
	const float MAX_UPWARD_PITCH = 40.00f;
	const float MAX_DOWNARD_PITCH = 84.00f;

	// how quickly the cannon will pitch up or down.
	const float PITCH_DOWN_SPEED = 5.0f;
	const float PITCH_UP_SPEED = -5.0f;
	public float angle;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
		if (Input.GetKey ("up")) {
			transform.RotateAround (new Vector3 (0,0,0), new Vector3(1,0,0), Time.deltaTime * PITCH_UP_SPEED);
		}
			//(new Vector3(Time.deltaTime * PITCH_UP_SPEED, 0 ,0));
		else if (Input.GetKey("down"))
			transform.RotateAround (new Vector3 (0,0,0), new Vector3(1,0,0), Time.deltaTime * PITCH_DOWN_SPEED);

		angle = transform.localRotation.x;
		Debug.Log(angle);
	}

}
