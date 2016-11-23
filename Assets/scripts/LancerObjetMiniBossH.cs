using UnityEngine;
using System.Collections;

public class LancerObjetMiniBossH : MonoBehaviour {

	public GameObject projectile4;

	public Transform pointLancement4;
	public float tempsEntreTir;
	private float chargeH;


	// Use this for initialization
	void Start () {
		chargeH = tempsEntreTir;
	}

	// Update is called once per frame
	void Update () {
		//lanceProjectile (transform.up, (-1 * forceTir));
		GameObject heros = GameObject.Find ("Perso");
		chargeH -= Time.deltaTime;

		if (heros != null && chargeH<0) {

			GameObject proj2 = Instantiate (projectile4, pointLancement4.position, transform.localRotation) as GameObject;
			chargeH = tempsEntreTir;
			Rigidbody2D rbProj2 = proj2.GetComponent<Rigidbody2D> ();

			rbProj2.velocity = new Vector2 (0,10);



		}

	}

}