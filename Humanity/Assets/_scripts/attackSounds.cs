using UnityEngine;
using System.Collections;

public class attackSounds : MonoBehaviour {

	
	// Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.Space)) {
            if (!audio.isPlaying) {
                audio.Play();
            }
        }
    }
}
