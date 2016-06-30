using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed = 5f;


	Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
        // used to get the current position of the character to pass into the blendtree
		float up = Input.GetAxis("Vertical");
		float down = Input.GetAxis("Vertical");
		float right = Input.GetAxis("Horizontal");
		float left = Input.GetAxis ("Horizontal");

        // used for the blendtree values
		anim.SetFloat ("left", Mathf.Abs (left));
		anim.SetFloat ("right", Mathf.Abs (right));
		anim.SetFloat("up", Mathf.Abs(up));
		anim.SetFloat("down", Mathf.Abs(down));
		anim.SetFloat("downLeft", Mathf.Abs(down));
		anim.SetFloat("downRight", Mathf.Abs(down));
		anim.SetFloat("upLeft", Mathf.Abs(down));
		anim.SetFloat("upRight", Mathf.Abs(down));

        // character movements.
		if (Input.GetKey (KeyCode.D)) {
			transform.position += new Vector3 (speed * Time.deltaTime, 0.0f, 0.0f);
			anim.SetFloat ("movement", 4f);
		}
		if (Input.GetKey (KeyCode.A)) { 
			transform.position -= new Vector3 (speed * Time.deltaTime, 0.0f, 0.0f); 
			anim.SetFloat ("movement", 3f);

		} 
		if (Input.GetKey (KeyCode.W)) {
			transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
			anim.SetFloat ("movement", 2f);

		}
		if (Input.GetKey (KeyCode.S)) {
			transform.position -= new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
			anim.SetFloat("movement", 1f);

		}
        // character attack
		if (Input.GetKey (KeyCode.Space)) {
			anim.SetFloat("down", 2f);
			anim.SetFloat("up", 2f);
			anim.SetFloat("left", 2f);
			anim.SetFloat("right", 2f);
			anim.SetFloat("downLeft", 2f);
			anim.SetFloat("downRight", 2f);
			anim.SetFloat("upLeft", 2f);
			anim.SetFloat("upRight", 2f);
		}
        // diagonal movement
		if((Input.GetKey (KeyCode.S)) && (Input.GetKey (KeyCode.D))) {
			anim.SetFloat("movement", 6f);
		}
		if((Input.GetKey (KeyCode.S)) && (Input.GetKey (KeyCode.A))) {
			anim.SetFloat("movement", 5f);
		}
		if((Input.GetKey (KeyCode.W)) && (Input.GetKey (KeyCode.A))) {
			anim.SetFloat("movement", 7f);
		}
		if((Input.GetKey (KeyCode.W)) && (Input.GetKey (KeyCode.D))) {
			anim.SetFloat("movement", 8f);
		}
	}

}