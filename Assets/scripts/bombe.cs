using UnityEngine;
using System.Collections;

public class bombe : MonoBehaviour {
	void OnTriggerEnter2D (Collider2D coll){
		//Debug.Log (coll.gameObject.name);
		if(coll.gameObject.transform.parent.name == "Perso"){
			GameObject.Destroy (this.gameObject);
		}
	}
}
