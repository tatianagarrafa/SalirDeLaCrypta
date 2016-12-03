using UnityEngine;
using System.Collections;

//https://www.youtube.com/watch?v=iLTP4EbM1N4
public class MouvChampignon : MonoBehaviour {
	public Transform [] PointsDaparition;
	public float tempsDaparition = 1.5f;
	public GameObject MiniBossChampignon;
	public Transform mesEnnemis;
	private Transform taupetransform;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("DeplacementChampignon", tempsDaparition, tempsDaparition);// Appel a la fonction du random des pointsde deplacement
		taupetransform = GetComponent<Transform>();
	}

	// Update is called once per frame
	void Update () {

	}

	void DeplacementChampignon(){
		int pointsIndex = Random.Range (0, PointsDaparition.Length);// Points de deplacement aleatoire
		taupetransform.gameObject.SetActive(false);
		taupetransform.position = PointsDaparition [pointsIndex].position;
		taupetransform.gameObject.SetActive(true);

		// instantier le champignon selon les points de deplacement.


	}

}
