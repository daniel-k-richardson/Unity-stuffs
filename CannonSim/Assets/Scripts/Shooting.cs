using UnityEngine;
using System.Collections;
//using System.IO.Ports;



public class Shooting : MonoBehaviour {
	public GameObject bulletPrefab;
	public GameObject newBulletObject;

	public Rigidbody rb;
	private Rigidbody newRb;
	public AudioClip cannonSound;
	private AudioSource source;

	private bool pressed = false;
	//private Vector3 offset = transform.rotation * new Vector3(0, 0.6f,0);
	public float timeCount;
	public string comPort;
	public float speed = 4000.0f;

	const float MAX_UPWARD_PITCH = 40.00f;
	const float MAX_DOWNARD_PITCH = 84.00f;

	// how quickly the cannon will pitch up or down.
	const float PITCH_DOWN_SPEED = 5.0f;
	const float PITCH_UP_SPEED = -5.0f;
	const float GRAVITY = 9.8f;
	public float minTilt = 0;
	public float maxTilt = -45;
//	private float old = 0;
	public float angle, yStart;
	private float lastInput;

//	SerialPort stream = new SerialPort("/dev/cu.usbmodem1421",115200);


	void Start(){
//		stream.Open();
	}
	void Awake() {
		source = GetComponent<AudioSource>();
	}




	public void Update() {

		//Debug.Log( stream.ReadLine());

//		float input = float.Parse(stream.ReadLine ());
		//if (Input.GetKey ("up")) {

		//transform.rotation= new Quaternion(minTilt+(maxTilt-minTilt)*(input/1028),0,0,1);
//		float diff = minTilt+(maxTilt-minTilt)*(input/1024) - old;
//		transform.RotateAround (new Vector3 (0,0,0), new Vector3(1,0,0),diff );
//		 old = minTilt+(maxTilt-minTilt)*(input/1024);
		//}
		//else if (Input.GetKey("down"))
			//transform.RotateAround (new Vector3 (0,0,0), new Vector3(1,0,0), (input/1028) * PITCH_DOWN_SPEED);

		angle = transform.localRotation.x;


		if(Input.GetKey(KeyCode.A) && !pressed) {
			
			pressed=!pressed;
			timeCount = 0;
			Vector3 offset = transform.rotation * new Vector3(0, 0.6f,0);
			Instantiate (bulletPrefab, transform.position + offset, Quaternion.Euler(0.0f,0.0f,0.0f));


			newBulletObject = GameObject.Find ("CannonBall(Clone)");
//			newBulletObject.transform.RotateAround (new Vector3 (0,0,0), new Vector3(1,0,0), float.Parse(stream.ReadLine ());
			//newBulletObject.transform.eulerAngles = new Vector3(0.0, 0.0, 90.0);
			newBulletObject.GetComponent<Rigidbody>().velocity= new Vector3(0f, speed*Mathf.Sin(Mathf.Deg2Rad*angle*-100), speed*Mathf.Cos(Mathf.Deg2Rad*angle*-100));
			source.Play();
			Debug.Log (Mathf.Sin(angle));
			Debug.Log (angle);

		}
		/*if (pressed) {
			
			timeCount += 1;
			Vector3 temp = new Vector3 (0, 0 + (speed * timeCount * Mathf.Tan (angle)) - ((GRAVITY * Mathf.Pow (speed * timeCount, 2) / (2 * Mathf.Pow (speed * Mathf.Cos (angle), 2)))), 0);
			Debug.Log (0 + (speed * timeCount * Mathf.Tan (angle)) - ((GRAVITY * Mathf.Pow (speed * timeCount, 2) / (2 * Mathf.Pow (speed * Mathf.Cos (angle), 2)))));
			newBulletObject.GetComponent<Transform>().position += temp;
		}*/
		if (GameObject.Find ("CannonBall(Clone)") == null) {
			pressed = !pressed;

			timeCount=0;


			
		}
	}
}
