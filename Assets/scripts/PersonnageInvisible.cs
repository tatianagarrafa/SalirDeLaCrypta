using UnityEngine;
using System.Collections;

public class PersonnageInvisible : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	void FixedUpdate () {
		PersonnageTransparent ();// Appel de la fanction personnage transparent

	}


	void PersonnageTransparent(){

		GameObject trouveEnnemi = GameObject.FindWithTag("champignon"); // Trouve les objets qui ont le tag champignon

		// Si le mini boos Taupe qui a le tag champignon n'existe pas le la tete du personnage devient transparente pour 10 secondes
		if (trouveEnnemi == null) {

			GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1, 0.5f);
			Debug.Log ("Je deviens transparent");
			//GetComponent<SpriteRenderer>().color = maCouleur;
			Invoke ("attendreSecondes",10);

		}


	}
		
		// Apres 10 seconds redevient visible
	void attendreSecondes() {

		//renderer.enabled = false;

		GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1, 1f);
		Debug.Log("Alpha normal");

	}

}
