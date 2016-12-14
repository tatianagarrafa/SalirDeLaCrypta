using UnityEngine;
using System.Collections;

public class pdvEnnemi : MonoBehaviour
{

	public float vieRestante;


<<<<<<< HEAD:Assets/scripts/PvEnnemis_Heros/pdvEnnemi.cs
	void Toucher (float dmg){
=======
	void Toucher (float dmg)
	{
>>>>>>> upstream/master:Assets/scripts/pdvEnnemi.cs
		vieRestante -= dmg;
		if (vieRestante <= 0) {
			GameObject.Destroy (this.gameObject);
		}
	}

<<<<<<< HEAD:Assets/scripts/PvEnnemis_Heros/pdvEnnemi.cs
=======

>>>>>>> upstream/master:Assets/scripts/pdvEnnemi.cs
}
