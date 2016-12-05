using UnityEngine;
using System.Collections;

public class pdvEnnemi : MonoBehaviour {

	public float vieRestante;

	void ToucherEnnemi (float dmg){
		vieRestante -= dmg;
		if(vieRestante<=0){
			GameObject.Destroy (this.gameObject);
		}
	
	}

	//void ToucherChamp (float dmg){
	//	vieRestante -= dmg;
	//	if(vieRestante<=0){
	//		GameObject.Destroy (this.gameObject);
	//	}

	//}
}
