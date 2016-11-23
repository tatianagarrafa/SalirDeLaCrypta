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
		GameObject.Destroy (this.gameObject);
		//Debug.Log (coll.gameObject.transform.parent.name);

		Rigidbody2D rbTouche = coll.gameObject.GetComponent <Rigidbody2D>();
		if (coll.gameObject.transform.parent.name == "mesEnnemis") {
			rbTouche.SendMessageUpwards ("Toucher", 1, SendMessageOptions.RequireReceiver);


		}
	}
}
