using UnityEngine;
using System.Collections;

public class projectile : MonoBehaviour {

	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter2D (Collision2D coll){

		//Debug.Log (coll.gameObject.name);
		GameObject.Destroy (this.gameObject);
		Rigidbody2D rbTouche = coll.gameObject.GetComponent <Rigidbody2D>();


		// j ai ajoute un tag pour gerer toutes les collisions projectile du hero et les clonnes des colonnes du champignon
		if (coll.gameObject.name == "ennemi" || coll.gameObject.tag == "momie" || coll.gameObject.tag == "taupe"
			|| coll.gameObject.tag == "ennemiordinaire") {

			rbTouche.SendMessageUpwards ("Toucher", 1, SendMessageOptions.RequireReceiver);


		}
			
	}
}
