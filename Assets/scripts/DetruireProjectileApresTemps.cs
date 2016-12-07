using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetruireProjectileApresTemps : MonoBehaviour {
	//http://answers.unity3d.com/questions/133894/deleting-bullets-after-a-few-seconds.html

	public float tempsPourDetruire = 1.0f;
		
	// Update is called once per frame
	void Update () {
		tempsPourDetruire += Time.deltaTime;
		if (tempsPourDetruire >= 4){
			GameObject.Destroy (gameObject);
		}
	}
}
