using UnityEngine;
using System.Collections;

public class Paralax : MonoBehaviour {

	public Camera mainCamera;
	private Vector3 previousPosition;
	// Use this for initialization
	void Start () {

		previousPosition = mainCamera.transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		float delta_x = mainCamera.transform.position.x - previousPosition.x;

		Vector3 newPos = new Vector3(transform.position.x + delta_x , transform.position.y , transform.position.z);
		//Debug log
		//Debug.Log(delta_x);
		//slide to delta_x
		transform.position = Vector3.Lerp(transform.position, newPos , Time.deltaTime * 100f);
		//update previous position
		previousPosition = mainCamera.transform.position;
	
	}
}
