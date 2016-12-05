using UnityEngine;
using System.Collections;

public class pdvHeros : MonoBehaviour {

	public float vieRestante;

	void ToucherHeros (float dmg){
		vieRestante -= dmg;
		if(vieRestante<=0){
			GameObject.Destroy (this.gameObject);
		}

	}
}
