using UnityEngine;
using System.Collections;

public class scriptSalle : MonoBehaviour {

	//==Variables==//
	public Transform[] items;
	public Sprite spritePorteOuverte;
	public Sprite spritePorteFerme;
	public bool PersoDetecte=false;
	private int _ennemis;
	private int _nbPortes;
	public Transform mesEnnemis;
	public Transform _mesPortes;
	public Transform pointRamassageBonus;
	public int nbitem;

	// Use this for initialization
	void Start () {
		nbitem = 0;
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
		_ennemis = mesEnnemis.childCount;

		if (PersoDetecte==true) {
			
			for (int i = 0; i < _nbPortes; i++) {
				Transform porte = _mesPortes.GetChild(i);
				_mesPortes.GetChild(i).GetComponent<SpriteRenderer> ().sprite = spritePorteFerme;
				_mesPortes.GetChild(i).GetComponent<BoxCollider2D> ().enabled = true;
			}
			PersoDetecte = false;
		}

		//==Gere l ouverture de la porte ou pas selon la presence d ennemi. S il n y pas d ennemi change le sprite et deactive le collider des portes==//
		if (_ennemis <= 0) {
			if(nbitem<1){
				this.GenererItems ();
				nbitem++;
			}
			 
			for (int i = 0; i < _nbPortes; i++) {
				_mesPortes.GetChild(i).GetComponent<SpriteRenderer> ().sprite = spritePorteOuverte;
				_mesPortes.GetChild(i).GetComponent<BoxCollider2D> ().enabled = false;
			}
		}

	}

	void GenererItems() {
			int nbaleatoire=Random.Range(0, items.Length);
			Transform bonusItem = GameObject.Instantiate (items [nbaleatoire], pointRamassageBonus.position, Quaternion.identity) as Transform;

	}

}
