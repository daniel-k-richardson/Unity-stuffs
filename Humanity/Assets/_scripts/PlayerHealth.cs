using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour 
{
	public GameObject explosionPrefab;
	public int health = 10;

	public void FixedUpdate()
	{
		if (health <= 0)
		{
			Application.LoadLevel(2);
		}
	}

	public void OnGUI()
	{
		GUI.Label(new Rect(30, 10, 300, 40), "Players Health: " + health);
	}
}
