using UnityEngine;
using System.Collections;

public class LancerObjetMiniBossMasque : MonoBehaviour {
	
	public GameObject projectileMasque;

	Transform player;
	public Transform pointLancement;
	public float tempsEntreTir;
	private float charge;


	// Use this for initialization
	void Start () {
		charge = tempsEntreTir;
	}

	// Update is called once per frame
	void Update () {
		
		GameObject heros = GameObject.Find ("Perso");
		charge -= Time.deltaTime;

		if (heros != null && charge<0 ) {

			GameObject proj2 = Instantiate (projectileMasque, pointLancement.position, transform.localRotation) as GameObject;
			charge = tempsEntreTir;
			Rigidbody2D rbProj2 = proj2.GetComponent<Rigidbody2D> ();

			rbProj2.velocity = new Vector2 (0,0);



		}

	}


}
