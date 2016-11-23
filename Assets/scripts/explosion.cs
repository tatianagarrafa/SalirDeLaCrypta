using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {

	public CircleCollider2D zoneExplosion;



	void explose(){
		zoneExplosion.enabled = true;
	
	}

	void finAnimation(){
		GameObject.Destroy (this.gameObject);

	}
}
