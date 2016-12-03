using UnityEngine;
using System.Collections;

//https://www.youtube.com/watch?v=iLTP4EbM1N4
public class MouvTaupe : MonoBehaviour {

	public Transform [] PointsDaparition;
	public float tempsDaparition = 1.5f;
	public GameObject MiniBossTaupe;
	public Transform mesEnnemis;
	private Transform taupetransform;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("DeplacementTaupe", tempsDaparition, tempsDaparition);// Appel a la fonction du random des pointsde deplacement
		taupetransform = GetComponent<Transform>();

	}

	// Update is called once per frame
	void Update () {

	}

	void DeplacementTaupe(){
		int pointsIndex = Random.Range (0, PointsDaparition.Length);// Points de deplacement aleatoire
		taupetransform.gameObject.SetActive(false);
		taupetransform.position = PointsDaparition [pointsIndex].position;
		taupetransform.gameObject.SetActive(true);
		//Transform NouvelleTaupe = GameObject.Instantiate (MiniBossTaupe, PointsDaparition [pointsIndex].position, PointsDaparition [pointsIndex].rotation) as Transform;// instantier la taupe
		//NouvelleTaupe.parent = mesEnnemis;																											//selon les points de deplacement

	}
}
