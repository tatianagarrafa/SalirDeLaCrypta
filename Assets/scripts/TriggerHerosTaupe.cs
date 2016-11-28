using UnityEngine;
using System.Collections;

public class TriggerHerosTaupe : MonoBehaviour {

	public GameObject MiniBossTaupe;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}


	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.name == "ZoneTaupe") {

			MiniBossTaupe = Instantiate<GameObject>(MiniBossTaupe);
			other.GetComponent<Collider2D>().enabled = false;

		}

	}
}
