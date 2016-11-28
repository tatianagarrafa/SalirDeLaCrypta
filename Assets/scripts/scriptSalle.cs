using UnityEngine;
using System.Collections;

public class scriptSalle : MonoBehaviour {

	//==Variables==//
	public Transform[] items;
	public Transform[] typeEnnemis;
	public Sprite spritePorteOuverte;
	public Sprite spritePorteFerme;
	public bool PersoDetecte=false;
	private bool peutOuvrir=false;
	private int _nbEnnemis;
	private int _nbPortes;
	public Transform mesEnnemis;
	public Transform _mesPortes;
	public Transform pointRamassageBonus;
	public int _nbitem;
	public int _ennemiMax=5;
	private float positionX;
	private float positionY;

	// Use this for initialization
	void Start () {
		_nbitem = 0;
		if (mesEnnemis == null) {
			mesEnnemis = transform.FindChild ("mesEnnemis");
		}

		if (_mesPortes == null) {
			_mesPortes= transform.FindChild ("_mesPortes");
		}

		_nbPortes = _mesPortes.childCount;
		positionX = pointRamassageBonus.position.x;
		positionY = pointRamassageBonus.position.y;
	}

	// Update is called once per frame
	void Update () {
		_nbEnnemis = mesEnnemis.childCount;

		if (PersoDetecte==true) {
			this.GenererEnnemis();
			this.fermerPortes();
			Destroy(mesEnnemis.GetChild (0).gameObject);
			peutOuvrir = true;
			PersoDetecte = false;
		}

		//==Gere l ouverture de la porte ou pas selon la presence d ennemi. S il n y pas d ennemi change le sprite et deactive le collider des portes==//
		if ((peutOuvrir==true) &&(_nbEnnemis <= 0) ) {
			if(_nbitem<1){
				this.GenererItems ();
				this.ouvrirPortes();
				_nbitem++;
				peutOuvrir = false;
			}
		}
	}
		
	void FixedUpdate(){

	}

	// fonction va generer aléetoirement un item de la salles
	void GenererItems() {
		int nbaleatoire=Random.Range(0, items.Length);
		Transform bonusItem = GameObject.Instantiate (items [nbaleatoire], pointRamassageBonus.position, Quaternion.identity) as Transform;
		if(bonusItem.name=="AucunObjet(Clone)"){
			Destroy (bonusItem.gameObject);
		}
	}

	// fonction va generer aléatoirement les ennemis de la salles 
	void GenererEnnemis(){
		for(int i=0 ; i<_ennemiMax; i++){
			Vector3 nouvellePosition = new Vector3(Random.Range((positionX -6.0f), (positionX + 6.0f)), Random.Range((positionY-4f), (positionY+4.0f)),0f);
			int nbaleatoire=Random.Range(0, typeEnnemis.Length);
			Transform nouvelEnnemi = GameObject.Instantiate (typeEnnemis [nbaleatoire], nouvellePosition, Quaternion.identity) as Transform;

			if(nouvelEnnemi.name=="AucunObjet(Clone)"){
				Destroy (nouvelEnnemi.gameObject);
			}	
			nouvelEnnemi.parent = mesEnnemis;
		}	
	}

	//function qui va fermer les portes de la salle
	void fermerPortes(){
		for (int i = 0; i < _nbPortes; i++) {
			_mesPortes.GetChild(i).GetComponent<SpriteRenderer> ().sprite = spritePorteFerme;
			_mesPortes.GetChild(i).GetComponent<BoxCollider2D> ().enabled = true;
		}
	}

	//function qui va ouvrir les portes de la salle
	void ouvrirPortes(){
		for (int i = 0; i < _nbPortes; i++) {
			_mesPortes.GetChild(i).GetComponent<SpriteRenderer> ().sprite = spritePorteOuverte;
			_mesPortes.GetChild(i).GetComponent<BoxCollider2D> ().enabled = false;
		}
	}
}
