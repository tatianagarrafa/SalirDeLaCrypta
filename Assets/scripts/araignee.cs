using UnityEngine;
using System.Collections;

public class araignee : MonoBehaviour {
	//answers.unity3d.com/questions/336663/random-movement-staying-in-an-area.html

	public float maxVitesse = 0.015f;

	//les limites du random
	private float maxX = 2f;
	private float minX = -2f;
	private float maxY = 2f;
	private float minY = -2f;

	public Transform PointInstantiation;

	private float x;
	private float y;
	private float monTemps;
	//private float angle;

	void Start(){
		//x = Random.Range (minX, maxX);
		//y = Random.Range (minY, maxY);

		//les limites du random
		//maxX = PointInstantiation.position.x + 2f;
		//minX = PointInstantiation.position.x-2f;
		//maxY = PointInstantiation.position.y + 2f;
		//minY = PointInstantiation.position.y-2f;

		x = Random.Range (-maxVitesse, maxVitesse);
		y = Random.Range (-maxVitesse, maxVitesse);
		//angle = Mathf.Atan2 (x,y) * Mathf.Rad2Deg;
		//Mathf.Rad2Deg - constante de conversion des radians pour degrés
		//angle = Mathf.Atan2 (x,y) * (180 / 3.141592f) + 90;
		//transform.localRotation = Quaternion.Euler (0, angle, 0);
		//transform.localRotation = Quaternion.Euler (angle, 0, 0);
	}
		
	
	// Update is called once per frame
	void Update () {
		monTemps += Time.deltaTime;

		if(transform.position.x > maxX){
			x = Random.Range (-maxVitesse, 0f);
			//x = Random.Range (minX, 0f);
		//	angle = Mathf.Atan2 (x,y) * (180 / 3.141592f) + 90;
			//transform.localRotation = Quaternion.Euler (0, angle, 0);
			//transform.localRotation = Quaternion.Euler (0, 0, angle);
			monTemps = 0f;
		}

		if(transform.position.x < minX){
			x = Random.Range (0f, maxVitesse);
			//x = Random.Range (0f, maxX);
			//angle = Mathf.Atan2 (x,y) * (180 / 3.141592f) + 90;
			//transform.localRotation = Quaternion.Euler (0, angle, 0);
			//transform.localRotation = Quaternion.Euler (0, 0, angle);
			monTemps = 0f;
		}

		if(transform.position.y > maxY){
			y = Random.Range (-maxVitesse, 0f);
			//y = Random.Range (minY, 0f);
			//angle = Mathf.Atan2 (x,y) * (180 / 3.141592f) + 90;
			//transform.localRotation = Quaternion.Euler (0, angle, 0);
			//transform.localRotation = Quaternion.Euler (0, 0, angle);
			monTemps = 0f;
		}

		if(transform.position.y < minY){
			y = Random.Range (0f, maxVitesse);
			//y = Random.Range (0f, maxY);
			//angle = Mathf.Atan2 (x,y) * (180 / 3.141592f) + 90;
			//transform.localRotation = Quaternion.Euler (0, angle, 0);
			//transform.localRotation = Quaternion.Euler (angle, 0, 0);
			monTemps = 0f;
		}

		if(monTemps > 1f){
			x = Random.Range (-maxVitesse, maxVitesse);
			y = Random.Range (-maxVitesse, maxVitesse);
			//angle = Mathf.Atan2 (x,y) * (180 / 3.141592f) + 90;
			//transform.localRotation = Quaternion.Euler (0, angle, 0);
			//transform.localRotation = Quaternion.Euler (angle, 0, 0);
			monTemps = 0f;
		}

		transform.position = new Vector2 (transform.position.x + x, transform.position.y + y);
	}
		
}
