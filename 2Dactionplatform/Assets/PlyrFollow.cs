using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyrFollow : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;
	public float minSizeY = 15f;
 	public float maxSizeY = 12f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		SetCameraPos();
		SetCameraSize();
	}

	void SetCameraPos(){
    Vector3 middle = (player1.transform.position + player2.transform.position) * 0.5f;
    transform.position = new Vector3(0 ,middle.y,-10);
	}

	void SetCameraSize() {
         //horizontal size is based on actual screen ratio
         float minSizeX = minSizeY * Screen.width / Screen.height;
 
         //multiplying by 0.5, because the ortographicSize is actually half the height
         float width = Mathf.Abs(player1.transform.position.x - player2.transform.position.x + 15) * 0.5f;
         float height = Mathf.Abs(player1.transform.position.y - player2.transform.position.y + 10) * 0.5f;
 
         //computing the size
         float camSizeX = Mathf.Max(width, minSizeX);
         Camera.main.orthographicSize = Mathf.Clamp(Mathf.Max(height, camSizeX * Screen.height / Screen.width, minSizeY), minSizeY, maxSizeY);
     }
}
