using UnityEngine;
using System.Collections;

public class projectileMiniBoss : MonoBehaviour {

	//public GameObject Player;

	void Start () {
		//GetComponent<BoxCollider2D>;


	}

	// Update is called once per frame
	void Update () {

	}




	void OnTriggerEnter2D(Collider2D Other)
	{

		// detruire les projectile des miniboss des qu ils touchent leurs salle respectives ou le hero
		if(Other.gameObject.tag=="zonechampignon" ||Other.gameObject.name=="Perso" || Other.gameObject.tag=="zonetaupe" || Other.gameObject.tag=="sallemomie"
			|| Other.gameObject.tag=="zonemasque"){
			
			GameObject.Destroy (this.gameObject);

			Debug.Log ("ToucherHeros");
		}
			
	}
}