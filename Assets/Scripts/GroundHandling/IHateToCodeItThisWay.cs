using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IHateToCodeItThisWay : MonoBehaviour
{
    void Update()
    {
        Vector2 pos;
        pos = new Vector2(10000000, 0);
        gameObject.transform.position = pos;
    }
}
