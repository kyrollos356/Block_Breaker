using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    private Paddle paddle;
    private bool gamestarted = false;
    private Vector3 paddleToBall;
    private Vector2 rigidboody = new Vector2(0.5f, 0.9f);
    Rigidbody2D rb;
    // Use this for initialization

    void Start () {
        paddle =GameObject.FindObjectOfType<Paddle>() ;
        paddleToBall = this.transform.position - paddle.transform.position;
	}

    // Update is called once per frame
    void Update()
    {
        if (!gamestarted )
        {//lock the ball position
            this.transform.position = paddleToBall + paddle.transform.position;
        //wait for a click for the ball launch
            if (Input.GetMouseButtonDown(0)) {
                gamestarted = true;
                rb = GetComponent<Rigidbody2D> () ;
                rb.velocity = new Vector2(1f , 3f);
                rb.AddForce(transform.up * 1);
            }
        }
    }
}
