using UnityEngine;
using System.Collections;

public class HabiliteChamp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D coll){

		//Debug.Log (coll.gameObject.name);
		if(coll.gameObject.name == "Perso"){


			//GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1, 0.5f);
			//GetComponent<BoxCollider2D> ().enabled = true;


			Invoke ("attendreSecondes",3);

		}

	}



	void attendreSecondes() {

		//renderer.enabled = false;
		GameObject.Destroy (this.gameObject);
		//GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1, 1f);
		//GetComponent<BoxCollider2D> ().enabled = false;
		Debug.Log("Alpha normal");

	}

}
