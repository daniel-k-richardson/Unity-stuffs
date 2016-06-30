using UnityEngine;
using System.Collections;

public class HumanityPoints : MonoBehaviour {
	public static int pointCounter;




	public void OnGUI()
	{
		GUI.Label (new Rect (350, 30, 300, 40), "Humaity points: " + pointCounter);
	}
}






