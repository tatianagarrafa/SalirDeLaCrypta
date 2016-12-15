using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetruireProjectileApresTemps : MonoBehaviour
{
	//http://answers.unity3d.com/questions/133894/deleting-bullets-after-a-few-seconds.html

	void start(){
		GameObject.Destroy (this.gameObject, 4);
	}
}
