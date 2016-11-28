using UnityEngine;
using System.Collections;

public class LancementSquelette : MonoBehaviour {
	public GameObject projectileSquelette;
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
		if (heros != null && charge < 0 ) {
			GameObject proj2 = Instantiate (projectileSquelette, pointLancement.position, transform.localRotation) as GameObject;
			charge = tempsEntreTir;
			Rigidbody2D rb2dProj2 = proj2.GetComponent<Rigidbody2D> ();
			rb2dProj2.velocity = new Vector2 (0,0);
		}
	}
}
