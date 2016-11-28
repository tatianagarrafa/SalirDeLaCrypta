using UnityEngine;
using System.Collections;

public class LancerObjetMiniBossChamp : MonoBehaviour {

	public GameObject projectileChamp1;
	public GameObject projectileChamp2;
	public GameObject projectileChamp3;
	public GameObject projectileChamp4;
	public GameObject projectileChamp5;

	public Transform pointLancement1;
	public Transform pointLancement2;
	public Transform pointLancement3;
	public Transform pointLancement4;
	public Transform pointLancement5;

	public float tempsEntreTir;
	private float charge;


	// Use this for initialization
	void Start () {
		charge = tempsEntreTir;
	}

	// Update is called once per frame
	void Update () {
		//lanceProjectile (transform.up, (-1 * forceTir));
		GameObject heros = GameObject.Find ("Perso");
		charge -= Time.deltaTime;


		if (heros != null && charge<0) {

			GameObject proj1	 = Instantiate (projectileChamp1, pointLancement1.position, transform.localRotation) as GameObject;
			charge = tempsEntreTir;
			Rigidbody2D rbProj1 = proj1.GetComponent<Rigidbody2D> ();

			rbProj1.velocity = new Vector2 (3,0);

			GameObject proj2 = Instantiate (projectileChamp2, pointLancement2.position, transform.localRotation) as GameObject;
			charge = tempsEntreTir;
			Rigidbody2D rbProj2 = proj2.GetComponent<Rigidbody2D> ();

			rbProj2.velocity = new Vector2 (-3,0);

			GameObject proj3 = Instantiate (projectileChamp3, pointLancement3.position, transform.localRotation) as GameObject;
			charge = tempsEntreTir;
			Rigidbody2D rbProj3 = proj3.GetComponent<Rigidbody2D> ();

			rbProj3.velocity = new Vector2 (0,-3);


			GameObject proj4 = Instantiate (projectileChamp4, pointLancement4.position, transform.localRotation) as GameObject;
			charge = tempsEntreTir;
			Rigidbody2D rbProj4 = proj4.GetComponent<Rigidbody2D> ();

			rbProj4.velocity = new Vector2 (5,3);

			GameObject proj5 = Instantiate (projectileChamp5, pointLancement5.position, transform.localRotation) as GameObject;
			charge = tempsEntreTir;
			Rigidbody2D rbProj5 = proj5.GetComponent<Rigidbody2D> ();

			rbProj5.velocity = new Vector2 (-5,3);

		}

	}
}
