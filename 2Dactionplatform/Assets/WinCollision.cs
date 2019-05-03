using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCollision : MonoBehaviour {

	public TouchLava _touchLava ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Player1")
		{
			_touchLava.Player1Win();

		}
		if(other.gameObject.tag == "Player2")
		{
			_touchLava.Player2Win();
		}
	}
}
