using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    public Transform cloud1;
    public Transform cloud2;
    public Transform cloud3;
    public Transform cloud4;

    public float speed = 15f;
    private float yInitial1;
    private float yInitial2;
    private float yInitial3;
    private float yInitial4;

    Vector3 newposition;

    private void Start()
    {
        yInitial1 = cloud1.transform.localPosition.y;
        yInitial2 = cloud2.transform.localPosition.y;
        yInitial3 = cloud3.transform.localPosition.y;
        yInitial4 = cloud4.transform.localPosition.y;
    }

    void Update()
    {
        newposition.x = Time.deltaTime * speed;
        cloud1.transform.localPosition -= newposition;
        cloud2.transform.localPosition -= newposition;
        cloud3.transform.localPosition -= newposition;
        cloud4.transform.localPosition -= newposition;

        //yes
        if (cloud1.transform.localPosition.x < -80)
        {
            cloud1.transform.localPosition = new Vector3(0, yInitial1, 0); 
        }

        if (cloud2.transform.localPosition.x < -100)
        {
            cloud2.transform.localPosition = new Vector3(0, yInitial2, 0);
        }

        if (cloud3.transform.localPosition.x < -100)
        {
            cloud3.transform.localPosition = new Vector3(0, yInitial3, 0);
        }

        if (cloud4.transform.localPosition.x < -80)
        {
            cloud4.transform.localPosition = new Vector3(0, yInitial4, 0);
        }
    }
}
