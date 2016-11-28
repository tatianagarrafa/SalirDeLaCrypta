using UnityEngine;
using System.Collections;

//https://www.youtube.com/watch?v=iLTP4EbM1N4
public class MouvChampignon : MonoBehaviour {
	public Transform [] PointsDaparition;
	public float tempsDaparition = 1.5f;
	public GameObject MiniBossChampignon;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("DeplacementChampignon", tempsDaparition, tempsDaparition);// Appel a la fonction du random des pointsde deplacement

	}

	// Update is called once per frame
	void Update () {

	}

	void DeplacementChampignon(){
		int pointsIndex = Random.Range (0, PointsDaparition.Length);// Points de deplacement aleatoire
		Instantiate (MiniBossChampignon, PointsDaparition [pointsIndex].position, PointsDaparition [pointsIndex].rotation);// instantier le champignon selon les points de deplacement.


	}

}
