using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
    public float depth = 1;
    public float speed = 1f;


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 pos = transform.position;

        pos.x -= speed * Time.fixedDeltaTime;
        Debug.Log(pos.x);

        transform.position = pos;
    }
}
