using UnityEngine;
using System.Collections;

public class TriggerHeroMomie : MonoBehaviour {

	public GameObject MiniBossMomie;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}


	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.name == "ZoneMomie") {

			MiniBossMomie = Instantiate<GameObject>(MiniBossMomie);
			other.GetComponent<Collider2D>().enabled = false;

		}

	}
}
