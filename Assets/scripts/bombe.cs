using UnityEngine;
using System.Collections;

public class bombe : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D coll){

		//Debug.Log (coll.gameObject.name);
		if(coll.gameObject.name == "Perso"){
			GameObject.Destroy (this.gameObject);

		}
		//
		/*Rigidbody2D rbTouche = coll.gameObject.GetComponent <Rigidbody2D>();
		if (coll.gameObject.name == "ennemi") {
			rbTouche.SendMessageUpwards ("Toucher", 1, SendMessageOptions.RequireReceiver);
		}*/
	}
}
