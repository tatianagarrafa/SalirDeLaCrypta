using UnityEngine;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

public class scriptSenseurPassage : MonoBehaviour {
	public Transform maCamera;
	private Rigidbody2D rb; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () { 
	
	}
	//au contact avec le personnage, applique une translation sur le personnage selon son axe de deplacement 
	//Ref. pour Galcer le movement du personnage: http://answers.unity3d.com/questions/747872/freeze-rigidbody-position-in-script.html
	void OnTriggerEnter2D(Collider2D coll){

		if (coll.gameObject.transform.name == "Perso") {
			
			rb = coll.gameObject.GetComponent<Rigidbody2D> ();
			float hori = Input.GetAxis ("Horizontal");
			float verti = Input.GetAxis ("Vertical");
			Debug.Log (rb.velocity);

			if(hori<0){
				
				rb.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
				rb.velocity.Set(0,0);
				coll.transform.Translate(Vector3.left  * Time.deltaTime*100f);	

			}

			if(hori>0){
				
				rb.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
				rb.velocity.Set(0,0);
				coll.transform.Translate(Vector3.right  * Time.deltaTime*100f);
			}

			if(verti<0){
				
				rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
				rb.velocity.Set(0,0);
				coll.transform.Translate(Vector3.down  * Time.deltaTime*100f);
			}

			if(verti>0){
				
				rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
				rb.velocity.Set(0,0);
				coll.transform.Translate(Vector3.up  * Time.deltaTime*100f);
			}
			StartCoroutine(arretMovPerso());
		}
	}
	//ref:https://docs.unity3d.com/ScriptReference/WaitForSeconds.html
	IEnumerator arretMovPerso() {
		//print(Time.time);
		yield return new WaitForSeconds(1);
		rb.constraints =  RigidbodyConstraints2D.FreezeRotation;
	}
}
