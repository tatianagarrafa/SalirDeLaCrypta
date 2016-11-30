using UnityEngine;
using System.Collections;

public class bombe : MonoBehaviour {
	void OnTriggerEnter2D (Collider2D coll){
		//Debug.Log (coll.gameObject.name);
		if(coll.gameObject.name == "Perso" || coll.gameObject.name == "PersoR"){
			GameObject.Destroy (this.gameObject);
		}
	}
}
