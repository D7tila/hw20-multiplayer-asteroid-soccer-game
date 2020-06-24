﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCenterController : MonoBehaviour
{
    static int goalScore = 0;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collision)
    {   
        Debug.Log("goalCenter trigger");
        if (collision.gameObject.tag.Equals("Ball"))
        {
            ScoreScript.scoreValue += 1;
            Destroy (collision.gameObject); // Destroy the colliding socccer ball
            Destroy(gameObject); // Destroy the goal...probably don't want to destroy this
            Debug.Log($"score: {ScoreScript.scoreValue}");
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
