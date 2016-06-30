using UnityEngine;
using System.Collections;

public class RoomEnter : MonoBehaviour {

	
	public void OnCollisionEnter2D(Collision2D coll)
	{
		Application.LoadLevel(3);
	}
}
