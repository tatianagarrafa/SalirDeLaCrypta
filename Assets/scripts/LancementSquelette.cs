using UnityEngine;
using System.Collections;


public class LancementSquelette : MonoBehaviour {
	
	public GameObject projectileSquelette;
	public Transform player;
	public Transform pointLancement;
	public float forceTir = 500f;
	public float tempsEntreTir;
	private float charge;


	// Use this for initialization
	void Start () {
		charge = tempsEntreTir;
	}

	// Update is called once per frame
	void Update () {
		//trouver le personnage
		GameObject heros = GameObject.Find ("Perso");
		charge -= Time.deltaTime;

		// Si le heros est vivant lance le projectile
		if (heros != null && charge < 0 ) {
			GameObject projectileSqueletteClone = Instantiate (projectileSquelette, pointLancement.position, transform.localRotation) as GameObject;
			charge = tempsEntreTir;
			Rigidbody2D rb2dProjectileSqueletteClone = projectileSqueletteClone.GetComponent<Rigidbody2D> ();
			rb2dProjectileSqueletteClone.AddForce (transform.up * forceTir);
			//rb2dProjectileSqueletteClone.velocity = new Vector2 (0,0);
		}
	}
		
}
