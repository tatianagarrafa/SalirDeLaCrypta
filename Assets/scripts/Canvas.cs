using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Canvas : MonoBehaviour
{
	//écran de départ
	public GameObject ecranDemarrage;

	// Use this for initialization
	void Start ()
	{
		ecranDemarrage.gameObject.SetActive (true);
		Time.timeScale = 0;
	}

	public void JouerJeu (string maScene)
	{
		Debug.Log ("Commencer le jeu");
		SceneManager.LoadScene ("travailJulien_julien");
		ecranDemarrage.gameObject.SetActive (false);
		Time.timeScale = 1;
	}
}
