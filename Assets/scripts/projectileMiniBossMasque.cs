using UnityEngine;
using System.Collections;

public class projectileMiniBossMasque : MonoBehaviour {

	public GameObject projectileInstantier;
	//public Transform pointLancement;
	//public GameObject Player;

	void Start () {
		//GetComponent<BoxCollider2D>;


	}

	// Update is called once per frame
	void Update () {

	}





	//void OnCollisionEnter2D (Collision2D coll){

	//	if (coll.gameObject.tag == "zonemasque") {
	//		GameObject.Destroy (this.gameObject);

	//	}

	//	Rigidbody2D rbToucheHeros = coll.gameObject.GetComponent <Rigidbody2D>();
	//	if (coll.gameObject.name == "Perso") {
	//		rbToucheHeros.SendMessageUpwards ("ToucherHeros", 1, SendMessageOptions.RequireReceiver);




	//	}




	
	//}
	void OnTriggerEnter2D(Collider2D Other) {
		if(Other.gameObject.tag=="zonemasque"){
			//salleScript.PersoDetecte = true;
			GameObject.Destroy (this.gameObject);
			//Rigidbody2D rbToucheHeros = Other.gameObject.GetComponent <Rigidbody2D>();
			//rbToucheHeros.SendMessageUpwards ("ToucherHeros", 1, SendMessageOptions.RequireReceiver);
			Debug.Log ("ToucherSalleMasque");
		}





		if (Other.gameObject.name == "instantierProjectile") {
			
			Vector3 position = new Vector3(Random.Range(44.80f, 60.0f), 3, Random.Range(0.0f, 0.0f));
			Instantiate(projectileInstantier, position, Quaternion.identity);
			//GameObject proj2 = Instantiate<GameObject>(projectileInstantier);
			//other.GetComponent<Collider2D>().enabled = false;
			//GameObject proj2 = Instantiate (projectileInstantier, pointLancement.position, transform.localRotation) as GameObject;
			//GameObject proj2 = Instantiate (projectileInstantier, pointLancement.position, transform.rotation) as GameObject;
			//charge = tempsEntreTir;
			//Rigidbody2D rbProj2 = proj2.GetComponent<Rigidbody2D> ();

			//rbProj2.velocity = new Vector3 (2,15);

		}
	}
}
