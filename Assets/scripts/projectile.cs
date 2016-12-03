using UnityEngine;
using System.Collections;

public class projectile : MonoBehaviour {

	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter2D (Collision2D coll){
		GameObject.Destroy (this.gameObject);

		Rigidbody2D rbToucheMiniBoss = coll.gameObject.GetComponent <Rigidbody2D>();

		if (coll.gameObject.transform.parent) {
			
			if (coll.gameObject.transform.parent.name == "mesEnnemis") {
				
				rbToucheMiniBoss.SendMessageUpwards ("ToucherMiniBoss", 1, SendMessageOptions.RequireReceiver);
				Debug.Log ("ToucherMiniBoss");

			}
		}
			
	}

	//void OnTriggerEnter2D(Collider2D Other) {
	//	if(Other.gameObject.name=="Perso"){
			//salleScript.PersoDetecte = true;
	//		GameObject.Destroy (this.gameObject);
			//Rigidbody2D rbToucheHeros = Other.gameObject.GetComponent <Rigidbody2D>();
			//rbToucheHeros.SendMessageUpwards ("ToucherHeros", 1, SendMessageOptions.RequireReceiver);
	//		Debug.Log ("ToucherHeros");
	//	}
	//void OnCollisionEnter2D (Collision2D coll){

		//Debug.Log (coll.gameObject.name);
	//	GameObject.Destroy (this.gameObject);
	//	Rigidbody2D rbTouche = coll.gameObject.GetComponent <Rigidbody2D>();

		// j ai ajoute un tag pour gerer toutes les collisions projectile du hero et les clonnes des colonnes du champignon
		//if (coll.gameObject.name == "ennemi" || coll.gameObject.tag == "champignon" || coll.gameObject.tag == "taupe"
		//	|| coll.gameObject.tag == "ennemiordinaire") {
		//	rbTouche.SendMessageUpwards ("Toucher", 1, SendMessageOptions.RequireReceiver);
		//	Debug.Log ("Toucher");
		//}

	//}
//}
}