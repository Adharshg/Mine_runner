using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	/*public Image whiteScreen;
	public GameObject MainMenuUI;
	public GameObject Player1;
	public GameObject Player2;
	//public GameObject Lava;
	//public GameObject ScoreCanvas;
	//public float fadeSpeed;

	// Use this for initialization
	void Awake () {
		Player1.SetActive(false);
		Player2.SetActive(false);
		Lava.SetActive(false);
		ScoreCanvas.SetActive(false);
	}*/
	
	// Update is called once per frame
	public void PlayGame(){
		PlayerPrefs.DeleteAll();
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	public void QuitGame(){
		PlayerPrefs.DeleteAll();
		Application.Quit();
	}
}
