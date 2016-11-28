using UnityEngine;
using System.Collections;

public class LancerObjet : MonoBehaviour {
	public GameObject projectile;
	public Transform pointLancement;
	public float forceTir = 500f;
	public float tempsEntreTir = 3f;
	//private float timeStamp = Mathf.Infinity;
	private float chargeH =0f;
	private float chargeG =0f;
	private float chargeB =0f;
	private float chargeD =0f;
	public GameObject TransfertProj;

	public float tempsTransf = 5f;

	void Start () {
		GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1, 1f);
		TransfertProj.SetActive (false);


	}

	void FixedUpdate () {
		PersonnageTransparent ();// Appel de la fanction personnage transparent


	}

	// Update is called once per frame
	void Update () {
		


		// pour le delai : http://answers.unity3d.com/questions/675839/hold-down-mouse-0-and-every-5-seconds-instantiate.html
		// pour la rotation du projectile http://answers.unity3d.com/questions/630670/rotate-2d-sprite-towards-moving-direction.html

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			lanceProjectile (transform.up , (1 * forceTir), Quaternion.AngleAxis(90, Vector3.forward));
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			chargeH += Time.deltaTime;
		}
		if (Input.GetKeyUp (KeyCode.UpArrow)) {
			chargeH = 0;
		}
		if(chargeH >= tempsEntreTir){
			lanceProjectile (transform.up , (1 * forceTir), Quaternion.AngleAxis(90, Vector3.forward));
			chargeH= 0;
		}
		//----------------------
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			lanceProjectile (transform.right , (-1 * forceTir), Quaternion.AngleAxis(180, Vector3.forward));
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			chargeG += Time.deltaTime;
		}
		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			chargeG = 0;
		}
		if(chargeG >= tempsEntreTir){
			lanceProjectile (transform.right , (-1 * forceTir), Quaternion.AngleAxis(180, Vector3.forward));
			chargeG= 0;
		}
		//----------------------
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			lanceProjectile (transform.up , (-1 * forceTir), Quaternion.AngleAxis(-90, Vector3.forward));
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			chargeB += Time.deltaTime;
		}
		if (Input.GetKeyUp (KeyCode.DownArrow)) {
			chargeB = 0;
		}
		if(chargeB >= tempsEntreTir){
			lanceProjectile (transform.up , (-1 * forceTir), Quaternion.AngleAxis(-90, Vector3.forward));
			chargeB= 0;
		}

		//----------------------
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			lanceProjectile (transform.right , (1 * forceTir), Quaternion.AngleAxis(0, Vector3.forward));
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			chargeD += Time.deltaTime;
		}
		if (Input.GetKeyUp (KeyCode.RightArrow)) {
			chargeD = 0;
		}
		if(chargeD >= tempsEntreTir){
			lanceProjectile (transform.right , (1 * forceTir), Quaternion.AngleAxis(0, Vector3.forward));
			chargeD= 0;
		}




	}

	void lanceProjectile(Vector2 sens,float force, Quaternion quat){
		

			GameObject proj = Instantiate (projectile, pointLancement.position, quat) as GameObject;
			Rigidbody2D rbProj = proj.GetComponent<Rigidbody2D> ();
			rbProj.AddForce (sens * force);


		GameObject trouveEnnemiM = GameObject.FindWithTag("momie");

		if (trouveEnnemiM == null ) {
			
			GameObject projTransfert = Instantiate (TransfertProj,pointLancement.position, quat) as GameObject;
			Rigidbody2D rbProjTransfert = projTransfert.GetComponent<Rigidbody2D> ();
			rbProjTransfert.AddForce (sens * force);

			TransfertProj.SetActive (true);
			Invoke ("recupererProjectile",tempsTransf);
			//GetComponent<Renderer>().enabled = false;
			Debug.Log("boule noire");

			}


	}






	void recupererProjectile() {

		//GetComponent<Renderer>().enabled = true;
		//TransfertProj.SetActive (false);
		TransfertProj.GetComponent<Renderer>().enabled=false;
		//Destroy (GameObject.FindWithTag("detruire"));


	}

	void PersonnageTransparent(){

		GameObject trouveEnnemiT = GameObject.FindWithTag("taupe"); // Trouve les objets qui ont le tag taupe

		// Si le mini boos Taupe qui a le tag taupe n'existe pas  la tete du personnage devient transparente pour 5 secondes
		if (trouveEnnemiT == null) {

			GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1, 0.5f);
			Debug.Log ("Je deviens transparent");
			//GetComponent<SpriteRenderer>().color = maCouleur;
			Invoke ("attendreSecondes",5);

		}


	}

 void attendreSecondes() {
		
		//GetComponent<Renderer>().enabled = true;
		//TransfertProj.SetActive (true);
		GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1, 1f);
		Debug.Log("Alpha normal");
	

	}

}
