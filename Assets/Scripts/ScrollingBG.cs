using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBG : MonoBehaviour
{
    public float speed;

    [SerializeField] private Renderer bg;

    private void Update()
    {
        bg.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
