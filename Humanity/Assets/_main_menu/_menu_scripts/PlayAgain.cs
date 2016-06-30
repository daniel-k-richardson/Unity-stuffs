using UnityEngine;
using System.Collections;

public class PlayAgain : MonoBehaviour {
	// background for the start menu
	public Texture backgroundTexture;
	
	// display a start button and loads level 1 when clicked
	void OnGUI() {
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundTexture);
		
		if (GUI.Button(new Rect(Screen.width * .2f, Screen.height * .7f, Screen.width * .5f, Screen.height * .1f), "Respawn?")) {
			Application.LoadLevel(1);
		}
	}
}
