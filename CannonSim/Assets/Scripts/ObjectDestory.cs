using UnityEngine;
using System.Collections;

public class ObjectDestory : MonoBehaviour {
	public GameObject item;
	void OnTriggerEnter (Collider col)
	{
		
		Destroy(col.gameObject);
		Destroy(item.gameObject);
		Debug.Log ("WORKING");

	}
}
