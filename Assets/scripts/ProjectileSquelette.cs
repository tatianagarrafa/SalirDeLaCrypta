using UnityEngine;
using System.Collections;

public class ProjectileSquelette : MonoBehaviour {

	public GameObject Player;

	void OnTriggerEnter2D (Collider2D coll){
		Rigidbody2D rbToucheHeros = coll.gameObject.GetComponent <Rigidbody2D>();
		if (coll.gameObject.name == "Perso") {
			Debug.Log ("J'ai touché le perso");
			GameObject.Destroy (this.gameObject);
			rbToucheHeros.SendMessageUpwards ("ToucherHeros", 1, SendMessageOptions.RequireReceiver);
		}
	}


}
