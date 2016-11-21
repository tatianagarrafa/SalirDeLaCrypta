using UnityEngine;
using System.Collections;

public class LancerObjetMiniBossG : MonoBehaviour {

	public GameObject projectile2;

	public Transform pointLancement2;
	public float tempsEntreTir;
	private float chargeG;


	// Use this for initialization
	void Start () {
		chargeG = tempsEntreTir;
	}

	// Update is called once per frame
	void Update () {
		//lanceProjectile (transform.up, (-1 * forceTir));
		GameObject heros = GameObject.Find ("Perso");
		chargeG -= Time.deltaTime;

		if (heros != null && chargeG<0) {

			GameObject proj2 = Instantiate (projectile2, pointLancement2.position, transform.localRotation) as GameObject;
			chargeG = tempsEntreTir;
			Rigidbody2D rbProj2 = proj2.GetComponent<Rigidbody2D> ();

			rbProj2.velocity = new Vector2 (-3,0);



		}

	}




}
