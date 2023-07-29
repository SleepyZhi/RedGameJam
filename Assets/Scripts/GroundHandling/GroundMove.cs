using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
    public float speed = 1f;
    public float speedMultiplier = 0.001f;
    public float sender;

    void FixedUpdate()
    {
        Vector2 pos = transform.position;
        speed += speedMultiplier;
        pos.x -= speed * Time.fixedDeltaTime;

        
        sender = speed* Time.fixedDeltaTime;
        transform.position = pos;
    }


}
