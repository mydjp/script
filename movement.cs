using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public float moveSpeed = 10f;
	public float slowmoveSpeed = -5f;
	public float turnSpeed = 100f;
	public float slowturnSpeed = 5f;
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey(KeyCode.Space))
			transform.Translate(Vector3.forward * slowmoveSpeed * Time.deltaTime);

		transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.Keypad7))
			transform.Translate(Vector3.left * -slowmoveSpeed * Time.deltaTime);
		if(Input.GetKey(KeyCode.Keypad7))
			transform.Rotate(Vector3.forward, slowturnSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.Keypad9))
			transform.Translate(Vector3.left * slowmoveSpeed * Time.deltaTime);
		if(Input.GetKey(KeyCode.Keypad9))
			transform.Rotate(Vector3.forward, -slowturnSpeed * Time.deltaTime);
		
		if(Input.GetKey(KeyCode.Keypad8))
			transform.Rotate(Vector3.left * -turnSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.Keypad5))
			transform.Rotate(Vector3.left * turnSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.Keypad4))
			transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);

			if(Input.GetKey(KeyCode.Keypad6))
			transform.Rotate(Vector3.forward, -turnSpeed * Time.deltaTime);
		
		//transform.Rotate(Vector3.up, 0,0,0  Time.deltaTime * 2f);
	}
}
