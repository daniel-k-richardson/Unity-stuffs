using UnityEngine;
using System.Collections;

public class BackToMainScene : MonoBehaviour {



	public void OnCollisionEnter2D(Collision2D coll)
	{
		Application.LoadLevel(1);
	}
}
