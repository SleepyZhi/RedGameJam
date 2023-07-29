using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxMovement : MonoBehaviour
{
    public float speed;
    public float speedMultiplier;
    private Vector2 pos;
    public Vector2 initialPos;

    private void Start()
    {  
        initialPos = transform.position;
    }

    private void FixedUpdate()
    {
        pos = transform.position;
        speed += speedMultiplier;
        pos.x -= speed * Time.fixedDeltaTime;

        if (pos.x <= -50)
            pos.x = initialPos.x + 40;

        transform.position = pos;
        

        
    }
}
