using UnityEngine;
using System.Collections;

public class EnemysAttack : MonoBehaviour {


    public int damage = 10;

    public void OnCollisionEnter2D(Collision2D coll)
    {
        DecreaseHealth();
    }

    public void DecreaseHealth()
    {
        GetComponent<PlayerHealth>().health -= damage;
	
    }
}