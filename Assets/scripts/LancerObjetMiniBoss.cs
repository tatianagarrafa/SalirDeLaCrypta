using UnityEngine;
using System.Collections;

public class LancerObjetMiniBoss : MonoBehaviour {

	public GameObject projectile1;
	public Transform pointLancement1;
	public float tempsEntreTir;
	private float charge;


	// Use this for initialization
	void Start () {
		charge = tempsEntreTir;
	}

	// Update is called once per frame
	void Update () {
		//lanceProjectile (transform.up, (-1 * forceTir));
		GameObject heros = GameObject.Find ("Perso");// trouver le heros
		charge -= Time.deltaTime;

		// Si le heros est vivant lance le projectile
		if (heros != null && charge<0) {

			GameObject proj2 = Instantiate (projectile1, pointLancement1.position, transform.localRotation) as GameObject;
			charge = tempsEntreTir;
			Rigidbody2D rbProj2 = proj2.GetComponent<Rigidbody2D> ();

			rbProj2.velocity = new Vector2 (0,0);



		}

	}



}
