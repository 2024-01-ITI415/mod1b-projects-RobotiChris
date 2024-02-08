using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class AppleTree : MonoBehaviour {
    [Header("Set in Inspector")]
    // Prefab for instantiating apple
    public GameObject applePrefab;
    // Speed at which the AppeTree moves
    public float speed = 1f;
    // Distance where AppleTree turns around
    public float leftAndRightEdge = 10f;
    // Chance that the AppleTree will change directions
    public float chanceToChangeDirection = 0.1f;
    // Rate at which Apples will be instantiate
    public float secondsBetweenAppleDrop = 1f;

    void Start () {
        // Dropping apples every second
        Invoke("DropApple", 2f);
    }

    void DropApple()
    {
        GameObject apple = Instantiate(GameObject);

    }

    // Update is called once per frame
    void Update() {
        // Basic Movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        // Changing Direction
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //Move right
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); //Move left
        }

        
    }
}
