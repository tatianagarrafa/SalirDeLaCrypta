using UnityEngine;
using System.Collections;

public class RatSuitPerso : MonoBehaviour {
	public float DeplVitesse = 1f;
	private Transform playerCible;
	private bool directionDroite = false;

	// Update is called once per frame
	void Update () {
		if (playerCible == null) {
			GameObject go = GameObject.Find ("Perso");
			if (go != null) {
				playerCible = go.transform;
			}
		}

		if (playerCible == null)
			return;

		transform.position = Vector2.MoveTowards(transform.position, playerCible.position, DeplVitesse * Time.deltaTime);

		/*if(this.transform.position.x < playerCible.transform.position.x){
			Tourne ();
		}*/
	}

	/*void Tourne(){
 		transform.localScale.x *= -1; // Inverse le gameObject sur l'axe x (valeur * -1 = -valeur)
	}*/

}
