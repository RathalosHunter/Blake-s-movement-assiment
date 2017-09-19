using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
	public float movespeed;
	public float jumpforce;
	private Rigidbody rigid;
	// Use this for initialization
	void Start () 
	{
		rigid = GetComponent<Rigidbody> ();
		/*recomended values for script. 
		movespeed = 10f;
		jumpforce = 500f;*/
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (movespeed * Input.GetAxis ("Horizontal") * Time.deltaTime, 0f, movespeed * Input.GetAxis ("Vertical") * Time.deltaTime);
	}

	void FixedUpdate()
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			rigid.AddForce (Vector3.up * jumpforce);
		}
	}
}
