using UnityEngine;
using System.Collections;

public class HurtOnCollision : MonoBehaviour 
{
    public int damage = 10;

	public void OnTriggerEnter2D(Collider2D coll)
	{
		DecreaseHealth();
	}

	public void DecreaseHealth()
	{
		GetComponent<EnemysHealth>().health -= damage;

	}
}
