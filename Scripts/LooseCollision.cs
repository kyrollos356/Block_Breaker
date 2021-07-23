using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseCollision : MonoBehaviour {
    private LvlMngr level;
    void Start()
    {
        level = GameObject.FindObjectOfType<LvlMngr>() ;    
    }
    void OnCollisionEnter2D(Collision2D collision) {
        print("collision");
    }
    void OnTriggerEnter2D(Collider2D trigger) {
        print("trigger");
        level.LoadLevel("Loose");

    }
}
