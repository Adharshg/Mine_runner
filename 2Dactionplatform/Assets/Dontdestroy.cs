using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dontdestroy : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		 DontDestroyOnLoad(this.gameObject);
	}
}
