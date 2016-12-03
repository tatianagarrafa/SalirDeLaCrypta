using UnityEngine;
using System.Collections;

public class LancerObjetMiniBossHG : MonoBehaviour {

	public GameObject projectile6;
	public Transform pointLancement6;
	public float tempsEntreTir;
	private float chargeHG;

	// Use this for initialization
	void Start () {
		chargeHG = tempsEntreTir;
	}

	// Update is called once per frame
	void Update () {

		GameObject heros = GameObject.Find ("Perso");
		chargeHG -= Time.deltaTime;

		if (heros != null && chargeHG<0) {

			GameObject proj2 = Instantiate (projectile6, pointLancement6.position, transform.localRotation) as GameObject;
			chargeHG = tempsEntreTir;
			Rigidbody2D rbProj2 = proj2.GetComponent<Rigidbody2D> ();

			rbProj2.velocity = new Vector2 (-3,6);



		}

			
			
			
	}
		


}
