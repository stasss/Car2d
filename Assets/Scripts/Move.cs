using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	Rigidbody2D body;

	// Use this for initialization
	void Start () {
		body = this.GetComponentInChildren<Rigidbody2D>();
	
	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log(body);
		if(Input.GetKey("space")){
			//Debug.Log("move");
			body.AddForce(new Vector2(0,10));
			body.AddTorque(1f);
		}
	
	}
}
