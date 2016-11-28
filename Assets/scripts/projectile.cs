using UnityEngine;
using System.Collections;

public class projectile : MonoBehaviour {

	//public GameObject TransfertProj;

	// Use this for initialization
	void Start () {
		//GameObject trouveEnnemi = GameObject.Find ("ennemi");

		//if (trouveEnnemi == null) {
		//	Instantiate(TransfertProj, Vector3.zero, Quaternion.identity);
		//}
		//Invoke("CreateMyInstance", 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		//Invoke("CreateMyInstance", 3.0f);


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

	//void CreateMyInstance()
	//{
		
		//Instantiate(TransfertProj, Vector3.zero, Quaternion.identity);
		//Vector3 position = new Vector3(Random.Range(-5.0f, 5.0f), 3, Random.Range(0.0f, 0.0f));
		//Instantiate(TransfertProj, position, Quaternion.identity);
		//Instantiate (TransfertProj, transform.up, (1 * 2), Quaternion.AngleAxis (90, Vector3.forward));

	//}
}
