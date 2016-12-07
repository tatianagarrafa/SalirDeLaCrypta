﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class personnage : MonoBehaviour
{

	private Rigidbody2D rb;
	private Collider2D colli;
	public float vitesse = 1f;
	private float hori = 0f;
	private  float verti = 0f;
	public Text txtnbBombe;
	public Text txtnbVies;
	private int nbBombe = 0;
	public float nbVie = 3;
	public GameObject bombe;
	public Transform pointDepotBombe;


	// Use this for initialization
	void Start ()
	{
		this.rb = GetComponent<Rigidbody2D> ();
		this.colli = GetComponent<Collider2D> ();
		txtnbBombe.text = "0";
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.E) && nbBombe > 0) {
			GameObject bombeExplose = Instantiate (bombe, pointDepotBombe.position, transform.localRotation) as GameObject;
			nbBombe--;
			txtnbBombe.text = nbBombe.ToString ();

			//GameObject.Destroy (bombeExplose);
		}
	}

	void FixedUpdate ()
	{
		// https://forum.unity3d.com/threads/basic-2d-player-movement.257930/
		hori = Input.GetAxis ("Horizontal");
		verti = Input.GetAxis ("Vertical");
		this.rb.velocity = new Vector2 (hori * vitesse, verti * vitesse);
	}

	void OnTriggerEnter2D (Collider2D coll)
	{
		// Quand le projectile de la momie ou du masque ou de la taupe ou du champighon touche le heros , il perd des points de vie
		if (coll.gameObject.tag == "detruire") {
			//GameObject.Destroy (this.gameObject);
			//Debug.Log (nbVie);
			nbVie--;
			if (nbVie <= 0) {
				Debug.Log ("mort");
				txtnbVies.text = nbVie.ToString ();
			} else {
				txtnbVies.text = nbVie.ToString ();
			}
		}

		if (coll.gameObject.name == "bombe(Clone)") {
			nbBombe++;
			txtnbBombe.text = nbBombe.ToString ();
		}





		if (coll.gameObject.transform.parent) {

			if (coll.gameObject.transform.parent.name == "mesEnnemis") {
				//GameObject.Destroy (this.gameObject);
				//Debug.Log (nbVie);
				nbVie--;
				if (nbVie <= 0) {
					Debug.Log ("mort");
					txtnbVies.text = nbVie.ToString ();
				} else {
					txtnbVies.text = nbVie.ToString ();
				}


			}
		}


	}

	void OnTriggerExit2D (Collider2D coll)
	{
		//Debug.Log("out");
		this.colli.enabled = true;


	}
		


}
