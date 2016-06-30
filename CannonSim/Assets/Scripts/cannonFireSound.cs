using UnityEngine;
using System.Collections;

public class cannonFireSound : MonoBehaviour {

	public AudioClip cannonSound;
	private AudioSource source;

	void Awake() {
		source = GetComponent<AudioSource>();
	}

	void Update() {
		
		if (Input.GetKey(KeyCode.A))
			source.Play();
	}
}
