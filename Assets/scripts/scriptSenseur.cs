using UnityEngine;
using System.Collections;

public class scriptSenseur : MonoBehaviour {
	private Transform _salle;
	public scriptSalle salleScript;
	private Transform sensTrans;


	// Use this for initialization
	void Start () {
		//acceder au script de la salle pour recuper la variable du nombre de porte;
		this.sensTrans = GetComponent<Transform>();

		Transform _salle = this.sensTrans.parent;

		//sonAlerte = GetComponent<AudioSource>();
		if (_salle != null) {
			salleScript = _salle.GetComponent<scriptSalle> ();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D Other)
	{
		if(Other.gameObject.name=="Perso"){
			salleScript.PersoDetecte = true;
			GameObject.Destroy (this.gameObject);
			//Debug.Log("Mesure: " + sensTrans.GetComponent <BoxCollider2D>().size.x);
		}
			
	}
}
