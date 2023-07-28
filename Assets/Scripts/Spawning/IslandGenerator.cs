using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandGenerator : MonoBehaviour
{
    [SerializeField] private Transform islandPart1;

    private void Awake()
    {
        Instantiate(islandPart1, new Vector3(134, 9), Quaternion.identity);
    }

}
