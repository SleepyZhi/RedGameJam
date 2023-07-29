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

    public GameObject obstacle;
    public GameObject berries;
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

    void generateGround()
    {
        GameObject go = Instantiate(gameObject);
        BoxCollider2D goCollider = go.GetComponent<BoxCollider2D>();
        Vector2 pos;

        float actualHeight = Random.Range(minHeight, maxHeight) - goCollider.size.y / 2;

        pos.y = actualHeight;
        pos.x = screenRight + actualGapSize;

        go.transform.position = pos;

        GroundHandler goGround = go.GetComponent<GroundHandler>();
        goGround.groundHeight= go.transform.position.y + (goCollider.size.y / 2);


        int obstacleNum = Random.Range(0, 2);
        for (int i = 0; i<obstacleNum; i++) 
        {
            GameObject box = Instantiate(obstacle.gameObject);
            float y = goGround.groundHeight;
            float halfWidth = goCollider.size.x / 2 - 1f;
            float left = go.transform.position.x - halfWidth;
            float right = go.transform.transform.position.x + halfWidth;
            float x = Random.Range(left,right);
            Vector2 boxPos = new Vector2(x,y);
            box.transform.position = boxPos;
        }

        int berriesNum = Random.Range(0, 4);
        for (int i = 0; i < berriesNum; i++)
        {
            GameObject berry = Instantiate(berries.gameObject);
            float y = goGround.groundHeight;
            float halfWidth = goCollider.size.x / 2 - 1f;
            float left = go.transform.position.x - halfWidth;
            float right = go.transform.transform.position.x + halfWidth;
            float x = Random.Range(left, right);
            Vector2 berryPos = new Vector2(x, y);
            berry.transform.position = berryPos;
        }
    

    }
}
