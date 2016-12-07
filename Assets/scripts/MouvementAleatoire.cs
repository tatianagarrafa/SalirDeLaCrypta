using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementAleatoire : MonoBehaviour {
	//answers.unity3d.com/questions/336663/random-movement-staying-in-an-area.html

	public float maxVitesse = 0.015f;

	//les limites du random
	private float maxX = 2f;
	private float minX = -2f;
	private float maxY = 2f;
	private float minY = -2f;

	public Transform PointInstantiation;

	private float x;
	private float y;
	private float monTemps;

	void Start(){
		x = Random.Range (-maxVitesse, maxVitesse);
		y = Random.Range (-maxVitesse, maxVitesse);
	}


	// Update is called once per frame
	void Update () {
		monTemps += Time.deltaTime;

		if(transform.position.x > maxX){
			x = Random.Range (-maxVitesse, 0f);
			monTemps = 0f;
		}

		if(transform.position.x < minX){
			x = Random.Range (0f, maxVitesse);
			monTemps = 0f;
		}

		if(transform.position.y > maxY){
			y = Random.Range (-maxVitesse, 0f);
			monTemps = 0f;
		}

		if(transform.position.y < minY){
			y = Random.Range (0f, maxVitesse);
			monTemps = 0f;
		}

		if(monTemps > 1f){
			x = Random.Range (-maxVitesse, maxVitesse);
			y = Random.Range (-maxVitesse, maxVitesse);
			monTemps = 0f;
		}

		transform.position = new Vector2 (transform.position.x + x, transform.position.y + y);
	}

}
