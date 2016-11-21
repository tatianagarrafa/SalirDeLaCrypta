using UnityEngine;
using System.Collections;

public class TeleporteMiniBoss : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnCollisionEnter2D (Collision2D coll){


	if (coll.gameObject.name == "projectile(Clone)") {
			transform.position = new Vector3 (Random.Range (-2, 2), Random.Range (-2, 2));// Limite du Random de la taupe dans la salle

		}

	}
		

}
