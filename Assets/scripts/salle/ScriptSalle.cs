using UnityEngine;
using System.Collections;

public class ScriptSalle : MonoBehaviour
{

	//==Variables==//
	public Transform[] items;
	public Sprite[] decorations;
	public Transform[] typeEnnemis;
	public Sprite spritePorteOuverte;
	public Transform maCamera;
	public Sprite spritePorteFerme;
	public bool PersoDetecte = false;
	public bool peutGenerEnnemis = false;
	private bool peutOuvrir = false;
	private int _nbEnnemis;
	private int _nbPortes;
	public Transform mesEnnemis;
	public Transform _mesPortes;
	public Transform pointRamassageBonus;
	public int _nbitem;
	public int _ennemiMax = 5;
	private float positionX;
	private float positionY;
	private Transform _tCibleCamera;
	private Vector3 _v3CibleCamera;
	private Vector3 _offset;
	private Transform _maDecoration;
	private Transform _passageSecret;
	private Transform _Pierre;
	private Transform _murPassage;
	private Transform _monTransform;

	// Use this for initialization
	void Start ()
	{
		
		_monTransform = GetComponent<Transform> ();//recuper le transform de ce ma salle
		_tCibleCamera = transform.FindChild ("pointInstantiation");//recuper le point La position du point instantiation  la position en z de ma camera
		_v3CibleCamera = _tCibleCamera.position;
		_v3CibleCamera.z = maCamera.position.z;

		//change les decorations de la salle (couleur dessin mur et du sol)
		if (_monTransform.name == "SalleBoss") {
			_maDecoration = transform.FindChild ("Decorations");
			if (_maDecoration != null) {
				for (int i = 8; i < 16; i++) {
					_maDecoration.GetChild (i).GetComponent<SpriteRenderer> ().sprite = decorations [1];
				}
			}
			transform.FindChild ("SalleSol").GetComponent<SpriteRenderer> ().sprite = decorations [0];
		}//--fin du changement de la decoration

		_nbitem = 0;
		_passageSecret = transform.FindChild ("passageSecret");//recuper le passage secret

		//recuper ces deux enfants du gameobjet dans des variables 
		if (_passageSecret != null) {
			_Pierre = _passageSecret.GetChild (3);// la pierre 
			_murPassage = _passageSecret.GetChild (1);//le passage
		}

		//recuper elements mesEnnemis 
		if (mesEnnemis == null) {
			mesEnnemis = transform.FindChild ("mesEnnemis");
		}
		//recuper element les portes pour avoir acces a ces enfants (les portes)
		if (_mesPortes == null) {
			_mesPortes = transform.FindChild ("_mesPortes");
		}

		_nbPortes = _mesPortes.childCount;//nombre de portes presentes dans la salle
		positionX = pointRamassageBonus.position.x;
		positionY = pointRamassageBonus.position.y;
	}
//--fin du Start

	// Update is called once per frame
	void Update ()
	{
		_nbEnnemis = mesEnnemis.childCount;// nombre d' ennemi present dans la salles
		//--fermes les portes et géner les ennemis 
		if (peutGenerEnnemis == true) {
			this.GenererEnnemis ();
			this.fermerPortes ();
			Destroy (mesEnnemis.GetChild (0).gameObject);
			peutOuvrir = true;
			peutGenerEnnemis = false;
		}//--fin condition peutGenererEnnemis

		//--a la detection du personnage change la position de la camera au point instantiation de cette salle
		if (PersoDetecte == true) {
			maCamera.position = _v3CibleCamera;
			PersoDetecte = !PersoDetecte;
		}//--fin de la condition de detection

		//==Gere l ouverture de la porte ou pas selon la presence d ennemi. S il n y pas d ennemi change le sprite et deactive le collider des portes==//
		if ((peutOuvrir == true) && (_nbEnnemis <= 0)) {
			if (_nbitem < 1) {
				this.GenererItems ();
				this.ouvrirPortes ();
				_nbitem++;
				peutOuvrir = false;
			}
		}
	}
//--fin de Update
		
	// fonction va generer aléatoirement un item de la salles selon le type de salle
	void GenererItems ()
	{
		int nbaleatoire;
		//Vector3 nouvellePosition;//position d'instantiation de objet

		//routine a suive si ce n'est pas la salle du boss ou du miniboss
		if ((_monTransform.name == "SalleBoss") || (_monTransform.name == "SalleSecrete")) {
			Transform bonusItem = GameObject.Instantiate (items [0], pointRamassageBonus.position, Quaternion.identity) as Transform;
		} // gener l'item du boss à la position du boss
		else {
			
			nbaleatoire = Random.Range (0, items.Length);
			Transform bonusItem = GameObject.Instantiate (items [nbaleatoire], pointRamassageBonus.position, Quaternion.identity) as Transform;
			if (bonusItem.name == "AucunObjet(Clone)") {
				Destroy (bonusItem.gameObject);
			}
		}
	}
//--Fin de la fonction GenerItems

	// fonction va generer aléatoirement les ennemis de la salles selon le type de salle
	void GenererEnnemis ()
	{
		Debug.Log ("Salle du " + _monTransform.name);
		Vector3 nouvellePosition;//position d'instantiation des ennemis

		//routine a suive si ce n'est pas la salle du boss ou du miniboss
		if ((_monTransform.name == "SalleBoss") || (_monTransform.name == "SalleSecrete")) {
			Debug.Log ("Salle du " + _monTransform.name);
<<<<<<< HEAD
			nouvellePosition = new Vector3 (positionX, positionY, 0f);
=======
			nouvellePosition = new Vector3 (positionX, positionX, 0f);
>>>>>>> upstream/master
			Transform nouvelEnnemi = GameObject.Instantiate (typeEnnemis [0], nouvellePosition, Quaternion.identity) as Transform;
			nouvelEnnemi.parent = mesEnnemis;
		} else {
			for (int i = 0; i < _ennemiMax; i++) {
				nouvellePosition = new Vector3 (Random.Range ((positionX - 6.0f), (positionX + 6.0f)), Random.Range ((positionY - 4f), (positionY + 4.0f)), 0f);
				int nbaleatoire = Random.Range (0, typeEnnemis.Length);
				Transform nouvelEnnemi = GameObject.Instantiate (typeEnnemis [nbaleatoire], nouvellePosition, Quaternion.identity) as Transform;

				if (nouvelEnnemi.name == "AucunObjet(Clone)") {
					Destroy (nouvelEnnemi.gameObject);
				}	
				nouvelEnnemi.parent = mesEnnemis;
			}
		}	
	}
//--fin de La fonction géner ennemis

	//function qui va fermer les portes de la salle ou du passage secret
	void fermerPortes ()
	{
		for (int i = 0; i < _nbPortes; i++) {
			_mesPortes.GetChild (i).GetComponent<SpriteRenderer> ().sprite = spritePorteFerme;
			_mesPortes.GetChild (i).GetComponent<BoxCollider2D> ().enabled = true;
			_mesPortes.GetChild (i).GetChild (0).gameObject.SetActive (false);//deactive le sprite superieur de la porte
		}
		if (_passageSecret != null) {
			//Debug.Log (_murePassage.gameObject.activeSelf);
			if (_murPassage.gameObject.activeSelf == true)
				_Pierre.gameObject.SetActive (true);
		}
	}
//--fin de la fonction fermePortes()

	//function qui va ouvrir les portes de la salle ou du passage secret
	void ouvrirPortes ()
	{
		for (int i = 0; i < _nbPortes; i++) {
			_mesPortes.GetChild (i).GetComponent<SpriteRenderer> ().sprite = spritePorteOuverte;
			_mesPortes.GetChild (i).GetComponent<BoxCollider2D> ().enabled = false;
			_mesPortes.GetChild (i).GetChild (0).gameObject.SetActive (true);//active le sprite superieur de la porte
		}
		if (_passageSecret != null) {
			//Debug.Log (_murePassage.gameObject.activeSelf);
			if ((_murPassage.gameObject.activeSelf == true) && (_murPassage.gameObject.activeSelf == true)) {
				Destroy (_Pierre.gameObject);
				Destroy (_passageSecret.GetComponent<Rigidbody2D> ());
			}
		}
	}
//fin de la fonction ouvrirPorte()
}
