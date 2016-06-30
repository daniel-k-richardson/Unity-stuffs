using UnityEngine;
using System.Collections;

public class EnemysHealth : MonoBehaviour {


    public int health = 10;
    private int maxHealth = 100;
    private Vector3 startPosition;

    public void FixedUpdate()
    {
        if (health <= 0)
        {
            KillAndReset();
        }
    }

    public void OnGUI()
    {
        GUI.Label(new Rect(30, 30, 300, 40), "Enemy's Health: " + health);
    }

    public void KillAndReset()
    {
        health = maxHealth;
        transform.position = startPosition;
		HumanityPoints.pointCounter += 10;

    }
}
