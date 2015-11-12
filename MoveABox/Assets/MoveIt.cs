using UnityEngine;
using System.Collections;

public class MoveIt : MonoBehaviour {
	public float Speed;
	SpriteRenderer SR;
	Rigidbody2D RB;
	// Use this for initialization
	void Start () {
	
		SR = GetComponent<SpriteRenderer> ();
		RB = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float XAxis = Input.GetAxis ("Horizontal");
		float YAxis = Input.GetAxis ("Vertical");


		RB.velocity = new Vector3 (XAxis * Speed, YAxis * Speed, 0);
		SR.color = new Color (Mathf.Abs (XAxis), 0, Mathf.Abs (YAxis), 1);
			
		if (Input.GetKey(KeyCode.Escape)){
			Application.Quit();
		}
	}
}
