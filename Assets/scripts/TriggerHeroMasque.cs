using UnityEngine;
using System.Collections;

public class TriggerHeroMasque : MonoBehaviour {
	public GameObject MiniBossMasque;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.name == "ZoneMasque") {

			MiniBossMasque = Instantiate<GameObject>(MiniBossMasque);
			other.GetComponent<Collider2D>().enabled = false;

		}

	}
}
