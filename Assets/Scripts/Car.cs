using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {

	public static float SEGMENT_MAX_LENGTH = 1f;
	public static float SEGMENT_MAX_ANGLE_LENGHT = 1f;
	private PolygonCollider2D collider;

	//private Vector2[] chromosome;

	// Use this for initialization
	void Start () {
		//Get polygon collider
		collider = GetComponent<PolygonCollider2D>();
		if(collider == null){
			collider = gameObject.AddComponent("PolygonCollider2D") as PolygonCollider2D;
		}
		Debug.Log(collider);

		Chromosome chrom = new Chromosome();

		collider.points = new Vector2[4]{new Vector2(0,5),new Vector2(5,0),new Vector2(0,-5), new Vector2(-5,0)};
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
