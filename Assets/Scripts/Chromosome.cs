using UnityEngine;
using System.Collections;

public class Chromosome{

	public static int SEGMENTS_LENGTH = 8;

	public static float SEGMENT_MAX_LENGTH = 1f;
	public static float SEGMENT_MAX_ANGLE_LENGHT = 1f;

	private Vector2[] chromosome;
	public Vector2[] chromosome_angles;

	public Chromosome(){
		//Randomly created chromosome
		chromosome = new Vector2[SEGMENTS_LENGTH];
		chromosome_angles = new Vector2[SEGMENTS_LENGTH];

		float angle_ratios_summ = 0f;

		Debug.Log(chromosome.Length);

		for(int i = 0; i < SEGMENTS_LENGTH ; i++){
			float segment_length = Random.value * SEGMENT_MAX_LENGTH;
			//Create angle ratios
			float angle_size = Random.value * SEGMENT_MAX_ANGLE_LENGHT;
			angle_ratios_summ += angle_size;
			chromosome[i] = new Vector2(segment_length , angle_size);
		}

		float k = (2 * Mathf.PI) / angle_ratios_summ;

		//Should be PI * 2
		float test = 0f;
		for(int c = 0 ; c < SEGMENTS_LENGTH; c++){
			chromosome_angles[c] = new Vector2(chromosome[c].x , chromosome[c].y * k);
			test+=chromosome[c].y * k;
		}



	}

}
