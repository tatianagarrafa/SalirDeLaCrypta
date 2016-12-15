using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperRat : MonoBehaviour {
	//pour le flip - https://www.youtube.com/watch?v=FHQyPgccD4M
	public bool directionDroite;
	private GameObject heros;
	//trouber la postition du rat
	private Vector2 positionRat;
	//trouber la postition du rat
	private Vector2 positionPerso;

	// Use this for initialization
	void Start () {
		directionDroite = false;
		heros = GameObject.Find("Perso");//trouver le personnage
		//position du rat
		positionRat = transform.position;
		//Debug.Log ("position du rat : " + positionRat);
	
	}
	
	// Update is called once per frame
	void Update () {
		if(heros){
			//position heros
			positionPerso = heros.transform.position;
			//Debug.Log (positionPerso);
		}
		Debug.Log ("position du heros : " + positionPerso.x);
		Debug.Log ("position du rat : " + positionRat.x);

		if(positionPerso.x > positionRat.x){
			Flipper ();
		}

	}

	void Flipper(){
		if(!directionDroite || directionDroite){
			directionDroite = !directionDroite;

			Vector2 theScale = transform.localScale;
			theScale *= -1;
			transform.localScale = theScale;
		}
	}

	/*private GameObject target;
	private Vector3 targetPoint;
	private Quaternion targetRotation;

	// Use this for initialization
	void Start () {
		target = GameObject.Find ("Perso");//trouver le personnage

	}

	// Update is called once per frame
	void Update() {
		targetPoint = new Vector3 (target.transform.position.x, transform.position.y, transform.position.z) - transform.position;
		targetRotation = Quaternion.LookRotation (-targetPoint, Vector3.up);
		transform.rotation = Quaternion.Slerp (transform.rotation, targetRotation, Time.deltaTime * 2f);
	}*/
}
