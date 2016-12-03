using UnityEngine;
using System.Collections;

public class ProjectileSuitHeros : MonoBehaviour {
	public float DeplVitesse = 3f;
	private Transform playerCible;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (playerCible == null) {

			GameObject go = GameObject.Find ("Perso");// Trouver le heros
			// Si le heros est vivant , applique le transform
			if (go != null)
			{
				playerCible = go.transform;

			}
		}

			if (playerCible == null)
				return;
			transform.position = Vector2.MoveTowards(transform.position, playerCible.position, DeplVitesse * Time.deltaTime);
	}


	//void OnCollisionEnter2D (Collision2D coll){
	//	GameObject.Destroy (this.gameObject);
	//	Rigidbody2D rbToucheHeros = coll.gameObject.GetComponent <Rigidbody2D>();

			//if (coll.gameObject.name == "Perso") {
			//	rbToucheHeros.SendMessageUpwards ("ToucherHeros", 1, SendMessageOptions.RequireReceiver);
			//	Debug.Log ("ToucherHeros");


		//}
	//}

	//void OnCollisionEnter2D (Collision2D coll){
	//	if (coll.gameObject.tag == "detruire") {
	//		GetComponent<BoxCollider2D> ().enabled = true;

	//	}

	//	Rigidbody2D rbToucheHeros = coll.gameObject.GetComponent <Rigidbody2D>();
	//	if (coll.gameObject.name == "Perso") {
	//		GameObject.Destroy (this.gameObject);
	//		rbToucheHeros.SendMessageUpwards ("ToucherHeros", 1, SendMessageOptions.RequireReceiver);
	//		Debug.Log ("ToucherHeros");


	//	}



//	}

	void OnTriggerEnter2D(Collider2D Other)
	{
		

			if(Other.gameObject.name=="Perso"){
			//salleScript.PersoDetecte = true;
			GameObject.Destroy (this.gameObject);
			Rigidbody2D rbToucheHeros = Other.gameObject.GetComponent <Rigidbody2D>();
			rbToucheHeros.SendMessageUpwards ("ToucherHeros", 1, SendMessageOptions.RequireReceiver);
			Debug.Log ("ToucherHeros");
		}

	}

	//void OnTriggerEnter(Collider col)
	//{
	//	if(col.GetComponent<Collider>().name == "Perso")
	//	{
	//		GameObject.Destroy (this.gameObject);
	//		Debug.Log ("ToucherHeros");
	//	}
	//}


}