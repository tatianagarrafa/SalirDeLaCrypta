using UnityEngine;
using System.Collections;

public class MiniBoss : MonoBehaviour {
	
	public float vieRestante;

	// Use this for initialization
	void Start () {
		
		vieRestante = 8.0f;

	}


	// Update is called once per frame
	void Update () {

	}

	//Reception de dommages

	void ToucherTaupeClone (float dmg){
		vieRestante -= dmg;
		if(vieRestante <=0){
			Debug.Log ("je le touche");
			GameObject.Destroy (this.gameObject);

		}

	}

	void ToucherMasque (float dmg){
		vieRestante -= dmg;
		if(vieRestante <=0){
			Debug.Log ("je le touche");
			GameObject.Destroy (this.gameObject);

		}

	}

	void ToucherMomie (float dmg){
		vieRestante -= dmg;
		if(vieRestante <=0){
			Debug.Log ("je le touche");
			GameObject.Destroy (this.gameObject);

		}

	}

	void ToucherChampignon (float dmg){
		vieRestante -= dmg;
		if(vieRestante <=0){
			Debug.Log ("je le touche");
			GameObject.Destroy (this.gameObject);

		}

	}


}
