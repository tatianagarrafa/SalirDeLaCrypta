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





	//void OnCollisionEnter2D (Collision2D coll){

	//	GameObject.Destroy (this.gameObject);



	//	Rigidbody2D rbToucheHeros = coll.gameObject.GetComponent <Rigidbody2D>();
	//	if (coll.gameObject.name == "Salle_TestTaupe") {
	//		rbToucheHeros.SendMessageUpwards ("ToucherHeros", 1, SendMessageOptions.RequireReceiver);
	//		Debug.Log ("ToucherHeros");


	//	}



//	}


	void OnTriggerEnter2D(Collider2D Other)
	{
		if(Other.gameObject.tag=="zonetaupe"){
			//salleScript.PersoDetecte = true;
			GameObject.Destroy (this.gameObject);
			//Rigidbody2D rbToucheHeros = Other.gameObject.GetComponent <Rigidbody2D>();
			//rbToucheHeros.SendMessageUpwards ("ToucherHeros", 1, SendMessageOptions.RequireReceiver);
			Debug.Log ("ToucherHeros");
		}

		if(Other.gameObject.name=="Perso"){
			//salleScript.PersoDetecte = true;
			GameObject.Destroy (this.gameObject);
			Rigidbody2D rbToucheHeros = Other.gameObject.GetComponent <Rigidbody2D>();
			rbToucheHeros.SendMessageUpwards ("ToucherHeros", 1, SendMessageOptions.RequireReceiver);
			Debug.Log ("ToucherHeros");
		}

	}
}
