using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour 
{
	public float bulletSpeed = 1f;
	public GameObject bulletPrefab;
    private Transform myTransform;
    float direction;
	
	public void Update() // needs to be Update (not FixedUpdate) so that Input.GetKeyDown functions correctly (otherwise, keypresses will be missed sometimes)
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{


            if ((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.A)) && (!Input.GetKey(KeyCode.S)) && (!Input.GetKey(KeyCode.W)))
            {

                GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, transform.rotation);
               Vector2 angle = new Vector2(Input.GetAxis("Horizontal"), 0);
                bullet.rigidbody2D.velocity = rigidbody2D.velocity + angle * bulletSpeed;
            }
            if ((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.S)) && (!Input.GetKey(KeyCode.D)) && (!Input.GetKey(KeyCode.A)))
            {
                GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, transform.rotation);
                Vector2 angle = new Vector2(0, Input.GetAxis("Vertical"));
                bullet.rigidbody2D.velocity = rigidbody2D.velocity + angle * bulletSpeed;
                }
            }
		}
	

   
}