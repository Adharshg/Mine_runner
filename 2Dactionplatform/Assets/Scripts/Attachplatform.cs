using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attachplatform : MonoBehaviour {

	public GameObject Player;

	void OnCollisionEnter2D(Collision2D other){
		
		if(other.gameObject.tag == "Player1")
		{
			Player.transform.parent = transform;
		}
		if(other.gameObject.tag == "Player2")
		{
			Player.transform.parent = transform;
		}
	}

	void OnCollisionExit2D(Collision2D other){
		
		if(other.gameObject.tag == "Player1")
		{
			Player.transform.parent = null;
		}
		if(other.gameObject.tag == "Player2")
		{
			Player.transform.parent = null;
		}
	}
}
