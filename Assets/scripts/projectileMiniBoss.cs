using UnityEngine;
using System.Collections;

public class projectileMiniBoss : MonoBehaviour {


	void OnTriggerEnter2D (Collider2D coll){

		Debug.Log(coll.gameObject.name);
		GameObject.Destroy (this.gameObject);

		if (coll.gameObject.transform.parent.name == "Perso") {
			Rigidbody2D rbToucheHeros = coll.gameObject.GetComponent <Rigidbody2D>();
			Debug.Log("toucher");
			rbToucheHeros.SendMessageUpwards ("Toucher", 1, SendMessageOptions.RequireReceiver);
		}
		else if(coll.gameObject.name == "patte"){
			Rigidbody2D rbToucheHeros = coll.gameObject.transform.parent.GetComponent <Rigidbody2D>();
			Debug.Log("toucher");
			rbToucheHeros.SendMessageUpwards ("Toucher", 1, SendMessageOptions.RequireReceiver);

		}

	}
}
