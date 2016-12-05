using UnityEngine;
using System.Collections;

public class projectileMiniBossMasque : MonoBehaviour {

	public GameObject Player;

	void OnCollisionEnter2D (Collision2D coll){
		Debug.Log ("J'ai touché le perso");
		GameObject.Destroy (this.gameObject);
		Rigidbody2D rbToucheHeros = coll.gameObject.GetComponent <Rigidbody2D>();
		if (coll.gameObject.name == "Perso") {
			rbToucheHeros.SendMessageUpwards ("ToucherHeros", 1, SendMessageOptions.RequireReceiver);
		}



	}
}
