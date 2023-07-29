using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxMovement : MonoBehaviour
{
    public float speed;
    public float speedMultiplier;
    private Vector2 pos;
    public Vector2 initialPos;


    private void FixedUpdate()
    {
        if (pos.x < -100)
        {
            pos.x = initialPos.x;
            transform.localPosition = pos;
        }

        pos = transform.localPosition;
        speed += speedMultiplier;
        pos.x -= speed * Time.fixedDeltaTime;

        
        transform.localPosition = pos;

    }
}
