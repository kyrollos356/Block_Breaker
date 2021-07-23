using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    private int timesHit;

    public int maxHits;

    private LvlMngr level;



    public static int breakableCount = 0;

    private bool isBrick;

    // Use this for initialization
    void Start() {
        timesHit = 0;
        isBrick = (this.tag == "Brick");
        Debug.Log("breakableCount = " + breakableCount);
        if (isBrick)
            breakableCount++;
    }

    // Update is called once per frame
    void Update() {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        if (timesHit >= maxHits) {
            breakableCount--;

            Debug.Log("breakableCount = " + breakableCount);
            Destroy(gameObject);
            
        }
        if (breakableCount <= 0) Win();
    }
    public static void Win()
    {
        LvlMngr.LoadWinNextLevel();
    }
}

    

