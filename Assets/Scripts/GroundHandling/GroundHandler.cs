using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundHandler : MonoBehaviour
{
    Player player;

    public float groundHeight;
    public float groundRight;
    public float screenRight;
    public float maxHeight;
    public float minHeight;
    public float gapSize;
    BoxCollider2D collider;

    private bool didGenerateGround = false;
    private float tempValue;
    private float actualGapSize;

    void Awake()
    {
        collider = GetComponent<BoxCollider2D>();
        groundHeight = transform.position.y + (collider.size.y / 2);
        screenRight = Camera.main.transform.position.x * 2;
    }

    private void FixedUpdate()
    {

        groundRight = transform.position.x + (collider.size.x /2);

        if(groundRight < 0) 
        {
            Destroy(gameObject);
            return;
        }

        if (!didGenerateGround)
            if (groundRight < screenRight) 
            {
                didGenerateGround = true;
               generateGround();
            }

        actualGapSize = gapSize;
    }

    private void generateGround()
    {
        GameObject go = Instantiate(gameObject);
        BoxCollider2D goCollider = go.GetComponent<BoxCollider2D>();
        Vector2 pos;

        float actualHeight = Random.Range(minHeight, maxHeight) - goCollider.size.y / 2;

        pos.y = actualHeight;
        pos.x = screenRight + actualGapSize;
        
        
        go.transform.position = pos;
    }
}
