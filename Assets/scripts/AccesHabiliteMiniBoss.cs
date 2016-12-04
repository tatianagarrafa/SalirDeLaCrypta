using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccesHabiliteMiniBoss : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D coll){

		//Debug.Log (coll.gameObject.name);
		if(coll.gameObject.name == "Perso"){
			GameObject.Destroy (this.gameObject);

		}

	}
}