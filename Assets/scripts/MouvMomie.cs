using UnityEngine;
using System.Collections;
//www.youtube.com/watch?v=1oMOcL0iO4A
public class MouvMomie : MonoBehaviour {
	public Vector3 projectileOffset = new Vector3 (0, 0.5f, 0);//Appliquer une nouvelle direction (vecteur3) pour le projectile
	public GameObject projectileMomie;
	int projectileCouche;
	public float tempsTir = 0.50f;
	float tempsEcoule = 0; // Initier le temps de deplacement momie
	Transform playerCible;

	void Start() {
		projectileCouche = gameObject.layer;// Appel au lancement du projectile

	}

	void Update () {
		if (playerCible == null) {
			GameObject go = GameObject.Find ("Perso");// trouver le heros
			if (go != null) {
				playerCible = go.transform;// Si le hero est vivant applique le transform sur le hero 

			}

		}

		tempsEcoule -= Time.deltaTime;

		// limitation de la projection de projectile sur le hero
		if (tempsEcoule <= 0 && playerCible != null && Vector3.Distance (transform.position, playerCible.position) < 5) 
		{
			tempsEcoule = tempsTir;
		// Instantier le projectile de la momie en suivant le heros 
			Vector3 offset = transform.rotation * projectileOffset;
			GameObject projectileGo = (GameObject)Instantiate (projectileMomie, transform.position + offset, transform.rotation);
			projectileGo.layer = projectileCouche;



		}
	}
}
