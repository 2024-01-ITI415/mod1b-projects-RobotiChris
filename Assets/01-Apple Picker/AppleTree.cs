using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    //prefab for instantiating apples
    public GameObject applePrefab;
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float chanceToChangeDirections = 0.1f;
    public float secondsBetweenAppleDrops = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //Dropping apples every second    
        Invoke("DropApple", 2f);
    }

    void DropApple()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
    //Basic Movement
    Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
    //Changing Directions
    if (pos.x < -leftAndRightEdge) {
            speed = Mathf.Abs(speed); 
        } else if (pos.x > leftAndRightEdge) {
            speed = -Mathf.Abs(speed);
        } else if ( Random.value < chanceToChangeDirections )
        {
            speed *= -1; //change direction
        }
    }

    void FixedUpdate()
    {
    if ( Random.value <  chanceToChangeDirections )
        {
            speed *= -1;
        }
    }
}
