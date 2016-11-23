using UnityEngine;
using System.Collections;

public class projectile : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D coll){

		//Debug.Log (coll.gameObject.name);
		GameObject.Destroy (this.gameObject);
		Rigidbody2D rbTouche = coll.gameObject.GetComponent <Rigidbody2D>();
		if (coll.gameObject.transform.parent.name == "mesEnnemis") {
			rbTouche.SendMessageUpwards ("Toucher", 1, SendMessageOptions.RequireReceiver);


		}
	}
}
