using UnityEngine;
using System.Collections;

public class LancementSquelette : MonoBehaviour
{
	
	public GameObject projectileSquelette;
	public Transform pointLancement;
	public float forceTir = 500f;
	public float tempsEntreTir;
	private float charge;
	private GameObject heros;
	private Vector2 directionProjectile = new Vector2 (1, 1	);//dirrection vers heros... trouver la manie de faire

	// Use this for initialization
	void Start ()
	{
		charge = tempsEntreTir;
		heros = GameObject.Find ("Perso");//trouver le personnage
	}

	// Update is called once per frame
	void Update ()
	{
		charge -= Time.deltaTime;

		// Lancer le projectile si le heros est vivant 
		if (charge < 0) {
			//Debug.Log ("Tire");
			GameObject projectileSqueletteClone = Instantiate (projectileSquelette, pointLancement.position, Quaternion.identity) as GameObject;
			charge = tempsEntreTir;
			Rigidbody2D rb2dProjectileSqueletteClone = projectileSqueletteClone.GetComponent<Rigidbody2D> ();
			//donner une force au projectile
			rb2dProjectileSqueletteClone.AddForce (directionProjectile * forceTir);
			//rb2dProjectileSqueletteClone.AddForce (transform.forward * forceTir);
			//rb2dProjectileSqueletteClone.velocity = transform.forward * forceTir;

		}
	}
		
}
