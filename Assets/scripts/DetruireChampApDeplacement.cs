using UnityEngine;
using System.Collections;

public class DetruireChampApDeplacement : MonoBehaviour {
	public float tempsDestruction = 3.0f;

	// Use this for initialization
	void Start () {

		Destroy (gameObject, tempsDestruction); // destruction du champignon
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
