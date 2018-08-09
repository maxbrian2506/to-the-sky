using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour {
	[SerializeField] float speed = 10f;
	[SerializeField] KeyCode upkey;
	[SerializeField] KeyCode DownKey;
	[SerializeField] KeyCode RightKey;
	[SerializeField] KeyCode LeftKey;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (upkey)) 
		{
			this.transform.Translate (new Vector3 (0f, speed, 0f)* Time.deltaTime );
		}
		if (Input.GetKey (DownKey)) 
		{
			this.transform.Translate (new Vector3 (0f, -speed, 0f) * Time.deltaTime);
		}
		if (Input.GetKey (RightKey)) 
		{
			this.transform.Translate (new Vector3 (speed,0f, 0f)* Time.deltaTime );
		}
		if (Input.GetKey (LeftKey)) 
		{
			this.transform.Translate (new Vector3 (-speed,0f, 0f) * Time.deltaTime);
		}
				
			
	}
}
