using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameUIs : MonoBehaviour {

	public GameObject Firsttext;
	public GameObject Secondtext;
	public GameObject Thirdtext;
	//public GameObject Fourthtext;
	private float Timer = 0f;
	private bool Flag1 = false;
	//public CharacterController controller;
	public GameObject TutorialScreen;


	void Start(){
		TutorialScreen.SetActive(true);
	}

	// Update is called once per frame
	void Update () {
		if (Flag1 == false){
			Timer += Time.deltaTime;
			if (Timer > 0.6f){
				Firsttext.SetActive(true);
				Flag1 = true;
				Timer = 0f;
			}
		}
		else{
			if (Timer > 4f){
				Timer += Time.deltaTime;
				Firsttext.SetActive(false);
				Secondtext.SetActive(true);
				if (Timer > 8f){
					Secondtext.SetActive(false);
					Thirdtext.SetActive(true);
				}
				if (Timer > 16f){
					Thirdtext.SetActive(false);
					TutorialScreen.SetActive(false);
				}
			}
		}
	}
}
