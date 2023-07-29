using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandGenerator : MonoBehaviour
{
    [SerializeField] private Transform islandPart1;

    private void Awake()
    {
        SpawnLevelPart(new Vector3(19, -1));
        SpawnLevelPart(new Vector3(19, -1) + new Vector3(30, 0));
        SpawnLevelPart(new Vector3(19, -1) + new Vector3(30+30, 0));
    }

    private void SpawnLevelPart(Vector3 spawnPosition)
    {
        Instantiate(islandPart1, spawnPosition, Quaternion.identity);
    }
}
