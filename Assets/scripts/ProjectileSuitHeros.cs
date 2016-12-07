using UnityEngine;
using System.Collections;

public class ProjectileSuitHeros : MonoBehaviour {
	public float DeplVitesse = 3f;
	private Transform playerCible;
	
	// Update is called once per frame
	void Update () {
		if (playerCible == null) {

			GameObject go = GameObject.Find ("Perso");// Trouver le heros
			// Si le heros est vivant , applique le transform
			if (go != null)
			{
				playerCible = go.transform;

			}
		}

		if (playerCible == null)
			return;
		
		transform.position = Vector2.MoveTowards(transform.position, playerCible.position, DeplVitesse * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D Other){
		// detruire le projectile de la momie des qu'il touche le heros
		if(Other.gameObject.name=="Perso"){
			GameObject.Destroy (this.gameObject);
		}

	}


}
