using UnityEngine;
using System.Collections;

public class LancerObjetMiniBossHD : MonoBehaviour {

	public GameObject projectile5;

	public Transform pointLancement5;
	public float tempsEntreTir;
	private float chargeHD;


	// Use this for initialization
	void Start () {
		chargeHD = tempsEntreTir;
	}

	// Update is called once per frame
	void Update () {
		//lanceProjectile (transform.up, (-1 * forceTir));
		GameObject heros = GameObject.Find ("Perso");
		chargeHD -= Time.deltaTime;

		if (heros != null && chargeHD<0) {

			GameObject proj2 = Instantiate (projectile5, pointLancement5.position, transform.localRotation) as GameObject;
			chargeHD = tempsEntreTir;
			Rigidbody2D rbProj2 = proj2.GetComponent<Rigidbody2D> ();

			rbProj2.velocity = new Vector2 (3,6);



	}



/*	void lanceProjectile(Vector2 sens,float force){
		GameObject heros = GameObject.Find ("Perso");
		if (heros != null) {

			GameObject proj2 = Instantiate (projectile5, pointLancement5.position, transform.localRotation) as GameObject;
			Rigidbody2D rbProj2 = proj2.GetComponent<Rigidbody2D> ();

			rbProj2.velocity = new Vector2 (6, 10);
			rbProj2.AddForce (transform.up * force);


		}*/


	}

}
