using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class pausemenuscript : MonoBehaviour {

	public static bool Gameispaused = false;
	public GameObject pauseMenuUI;

	// Use this for initialization
	void Start () {
		
	}
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (Gameispaused){
				Resume();
			}
			else{
				Pause();
			}
		}
	}

	public void Resume(){
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		Gameispaused = false;
	}

	void Pause(){
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		Gameispaused = true;
	}

	public void LoadMenu()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene(0);
	}

	public void QuitGame()
	{
		PlayerPrefs.DeleteAll();
		Application.Quit();
	}
}
