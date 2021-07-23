using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 paddleposition = new Vector3(0.09f , this.transform.position.y , 0f);
        float mouseposition =Input.mousePosition.x / Screen.width*16;
       paddleposition.x = Mathf.Clamp(mouseposition , 0.09f , 15.3f);
        this.transform.position = paddleposition;

	}
}
