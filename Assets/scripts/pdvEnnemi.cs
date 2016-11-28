using UnityEngine;
using System.Collections;

public class pdvEnnemi : MonoBehaviour {

	public float vieRestante;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Toucher (float dmg){
		vieRestante -= dmg;
		if(vieRestante<=0){
			GameObject.Destroy (this.gameObject);
		}
	
	}

	void ToucherChamp (float dmg){
		vieRestante -= dmg;
		if(vieRestante<=0){
			GameObject.Destroy (this.gameObject);
		}

	}
}
