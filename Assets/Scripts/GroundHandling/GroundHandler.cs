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

    //Referencing Game Objects
    public GameObject obstacle;
    public GameObject berries;
    public GameObject bush;
    public GameObject melons;
    public GameObject crocodile;
    public GameObject tree1;
    public GameObject tree2;
    public GameObject tree3;

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

        //yes
        int obstacleNum = Random.Range(0, 2);
        for (int i = 0; i<obstacleNum; i++) 
        {
            GameObject box = Instantiate(obstacle.gameObject);
            float y = goGround.groundHeight + 1.8f;
            float halfWidth = goCollider.size.x / 2;
            float left = go.transform.position.x - halfWidth;
            float right = go.transform.transform.position.x + halfWidth;
            float x = Random.Range(left + 10, right - 10);
            Vector2 boxPos = new Vector2(x,y);
            box.transform.position = boxPos;
        }

        int berriesNum = Random.Range(0, 4);
        for (int i = 0; i < berriesNum; i++)
        {
            GameObject berry = Instantiate(berries.gameObject);
            float y = goGround.groundHeight + 2f;
            float halfWidth = goCollider.size.x / 2;
            float left = go.transform.position.x - halfWidth;
            float right = go.transform.transform.position.x + halfWidth;
            float x = Random.Range(left+10, right-10);
            Vector2 berryPos = new Vector2(x, y);
            berry.transform.position = berryPos;
        }
        int melonNum = Random.Range(0, 4);
        if (melonNum == 1)
        {
            GameObject melon = Instantiate(melons.gameObject);
            float y = goGround.groundHeight + 2f;
            float halfWidth = goCollider.size.x / 2;
            float left = go.transform.position.x - halfWidth;
            float right = go.transform.transform.position.x + halfWidth;
            float x = Random.Range(left + 10, right - 10);
            Vector2 melonPos = new Vector2(x, y);
            melon.transform.position = melonPos;
        }

        //int crocNum = Random.Range(0, 2);
        //if (crocNum == 1)
        //{
        //    GameObject croc = Instantiate(crocodile.gameObject);
        //    float y = goGround.groundHeight + 0.5f;
        //    float halfWidth = goCollider.size.x / 2;
        //    float left = go.transform.position.x - halfWidth;
        //    float right = go.transform.transform.position.x + halfWidth;
        //    float x = Random.Range(left + 15, right - 10);
        //    Vector2 crocPos = new Vector2(x, y);
        //    croc.transform.position = crocPos;
        //}
            int bushesNum = Random.Range(0, 6);
        for (int i = 0; i < obstacleNum; i++)
        {
            GameObject box = Instantiate(bush.gameObject);
            float y = goGround.groundHeight + 1f;
            float halfWidth = goCollider.size.x / 2;
            float left = go.transform.position.x - halfWidth;
            float right = go.transform.transform.position.x + halfWidth;
            float x = Random.Range(left, right);
            Vector2 bushPos = new Vector2(x, y);
            box.transform.position = bushPos;
        }

        int tree1Num = Random.Range(0, 2);
        for (int i = 0; i < tree1Num; i++)
        {
            GameObject box = Instantiate(tree1.gameObject);
            float y = goGround.groundHeight + 3.5f;
            float halfWidth = goCollider.size.x / 2;
            float left = go.transform.position.x - halfWidth;
            float right = go.transform.transform.position.x + halfWidth;
            float x = Random.Range(left, right);
            Vector2 tree1Pos = new Vector2(x, y);
            box.transform.position = tree1Pos;
        }

        int tree2Num = Random.Range(0, 2);
        for (int i = 0; i < tree2Num; i++)
        {
            GameObject box = Instantiate(tree2.gameObject);
            float y = goGround.groundHeight + 3.5f;
            float halfWidth = goCollider.size.x / 2;
            float left = go.transform.position.x - halfWidth;
            float right = go.transform.transform.position.x + halfWidth;
            float x = Random.Range(left, right);
            Vector2 tree2Pos = new Vector2(x, y);
            box.transform.position = tree2Pos;
        }

        int tree3Num = Random.Range(0, 2);
        for (int i = 0; i < tree3Num; i++)
        {
            GameObject box = Instantiate(tree3.gameObject);
            float y = goGround.groundHeight + 3.5f;
            float halfWidth = goCollider.size.x / 2;
            float left = go.transform.position.x - halfWidth;
            float right = go.transform.transform.position.x + halfWidth;
            float x = Random.Range(left, right);
            Vector2 tree3Pos = new Vector2(x, y);
            box.transform.position = tree3Pos;
        }

    }
}
