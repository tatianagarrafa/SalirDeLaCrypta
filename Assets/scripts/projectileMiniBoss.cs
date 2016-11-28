using UnityEngine;
using System.Collections;

public class projectileMiniBoss : MonoBehaviour {

	//public GameObject Player;

	void Start () {
		//GetComponent<BoxCollider2D>;


	}

	// Update is called once per frame
	void Update () {

	}





	void OnCollisionEnter2D (Collision2D coll){

		GameObject.Destroy (this.gameObject);



		Rigidbody2D rbToucheHeros = coll.gameObject.GetComponent <Rigidbody2D>();
		if (coll.gameObject.name == "Perso") {
			rbToucheHeros.SendMessageUpwards ("ToucherHeros", 1, SendMessageOptions.RequireReceiver);
		}



	}
}
