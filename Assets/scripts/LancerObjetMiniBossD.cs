using UnityEngine;
using System.Collections;

public class LancerObjetMiniBossD : MonoBehaviour {

	public GameObject projectile3;

	public Transform pointLancement3;
	public float tempsEntreTir;
	private float chargeD;


	// Use this for initialization
	void Start () {
		chargeD = tempsEntreTir;
	}

	// Update is called once per frame
	void Update () {
		//lanceProjectile (transform.up, (-1 * forceTir));
		GameObject heros = GameObject.Find ("Perso");
		chargeD -= Time.deltaTime;


		if (heros != null && chargeD<0) {

			GameObject proj2 = Instantiate (projectile3, pointLancement3.position, transform.localRotation) as GameObject;
			chargeD = tempsEntreTir;
			Rigidbody2D rbProj2 = proj2.GetComponent<Rigidbody2D> ();

			rbProj2.velocity = new Vector2 (3,0);



		}

	}

}