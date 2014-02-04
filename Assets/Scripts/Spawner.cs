using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject currentCar;
	public Camera mainCamera;

	// Use this for initialization
	void Start () {
	   if(currentCar == null){
			Debug.Log("no car assigned");
	   }

	}
	
	// Update is called once per frame
	void Update () {
		float car_pos_x = currentCar.transform.position.x;
		float car_pos_y = currentCar.transform.position.y;

		mainCamera.transform.position = new Vector3(currentCar.transform.position.x,currentCar.transform.position.y,mainCamera.transform.position.z);

		//Debug.Log(currentCar.transform.position.x);
		if(car_pos_x >= 12){
			Destroy(currentCar);
		}
	}
}
