using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TouchLava : MonoBehaviour {

	public int player1Score = 0;
	public int player2Score = 0;
	public Text scoreText1;
	public Text scoreText2;
	public GameObject Player1text;
	public GameObject Player2text;
	public GameObject Player1;
	public GameObject Player2;


	// Use this for initialization
	void Start () {
		player1Score = PlayerPrefs.GetInt("score1");
		player2Score = PlayerPrefs.GetInt("score2");
		scoreText2.text = "     " + player2Score;
		scoreText1.text = player1Score + "     ";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Player1")
		{
			Player1Lose();

		}
		if(other.gameObject.tag == "Player2")
		{
			Player2Lose();
		}
	}

	void Player1Lose(){
		if (player1Score <= 0) player2Score += 1;
		else player1Score -= 1;
		scoreText2.text = "" + player2Score;
		scoreText1.text = "" + player1Score;
		PlayerPrefs.SetInt("score1", player1Score);
		PlayerPrefs.SetInt("score2", player2Score);
		SceneManager.LoadScene(1);
	}

	void Player2Lose(){
		if (player2Score <= 0) player1Score += 1;
		else player2Score -= 1;
		scoreText2.text = "" + player2Score;
		scoreText1.text = "" + player1Score;
		PlayerPrefs.SetInt("score1", player1Score);
		PlayerPrefs.SetInt("score2", player2Score);
		SceneManager.LoadScene(1);
	}

	public void Player1Win(){
		Player1.SetActive(false);
		Player2.SetActive(false);
		Time.timeScale = 0f;
		Player1text.SetActive(true);
	}

	public void Player2Win(){
		Player1.SetActive(false);
		Player2.SetActive(false);
		Time.timeScale = 0f;
		Player2text.SetActive(true);
	}
}
