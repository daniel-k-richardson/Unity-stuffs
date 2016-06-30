using UnityEngine;
using System.Collections;

public class movementSound : MonoBehaviour
{



    // Update is called once per frame

    // plays the movement sound when either of the directional keys are pressed.
    void Update() {
        if ((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.D)))) {
            if (!audio.isPlaying) {
                audio.Play();
            }
        }
    }
}
