using UnityEngine;
using System.Collections;


public class gravity : MonoBehaviour {
	public float g=0.0f;
	void Start() {
		Physics.gravity = new Vector3(0, g, 0);
	}
}