using UnityEngine;
using System.Collections;

public class scriptSalle : MonoBehaviour {

	//==Variables==//
	public Transform[] items;
	public Transform[] typeEnnemis;
	public Sprite spritePorteOuverte;
	public Sprite spritePorteFerme;
	public bool PersoDetecte=false;
	private int _nbEnnemis;
	private int _nbPortes;
	public Transform mesEnnemis;
	public Transform _mesPortes;
	public Transform pointRamassageBonus;
	public int _nbitem;
	public int _ennemiMax=5;
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

	}

	// Update is called once per frame
	void Update () {

		_nbEnnemis = mesEnnemis.childCount;

		if (PersoDetecte==true) {
			GenererEnnemis ();
			for (int i = 0; i < _nbPortes; i++) {
				Transform porte = _mesPortes.GetChild(i);
				_mesPortes.GetChild(i).GetComponent<SpriteRenderer> ().sprite = spritePorteFerme;
				_mesPortes.GetChild(i).GetComponent<BoxCollider2D> ().enabled = true;
			}
		
			PersoDetecte = false;
		}

		//==Gere l ouverture de la porte ou pas selon la presence d ennemi. S il n y pas d ennemi change le sprite et deactive le collider des portes==//
		if (_nbEnnemis <= 0) {
			if(_nbitem<1){
				this.GenererItems ();
				_nbitem++;
			}

			for (int i = 0; i < _nbPortes; i++) {
				_mesPortes.GetChild(i).GetComponent<SpriteRenderer> ().sprite = spritePorteOuverte;
				_mesPortes.GetChild(i).GetComponent<BoxCollider2D> ().enabled = false;
			}
		}

	}
	// fonction va generer aléetoirement un item de la salles
	void GenererItems() {
		int nbaleatoire=Random.Range(0, items.Length);
		Transform bonusItem = GameObject.Instantiate (items [nbaleatoire], pointRamassageBonus.position, Quaternion.identity) as Transform;

	}
	// fonction va generer aléatoirement les ennemis de la salles 
	void GenererEnnemis(){
		for(int i=0 ; i<_ennemiMax; i++){
			Vector3 nouvellePosition = new Vector3(Random.Range(-6.0f, 6.0f), Random.Range(-4f, 3.0f),0f);
			int nbaleatoire=Random.Range(0, typeEnnemis.Length-1);
			Debug.Log (nbaleatoire);
			Debug.Log (typeEnnemis.Length);
			Transform nouvelEnnemi = GameObject.Instantiate (typeEnnemis [nbaleatoire], nouvellePosition, Quaternion.identity) as Transform;
			Debug.Log ("enmmiCree: " + nouvelEnnemi + " " + i);	
			nouvelEnnemi.parent = mesEnnemis;
		}	
	}

}
