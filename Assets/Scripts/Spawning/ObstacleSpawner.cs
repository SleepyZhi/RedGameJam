using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] obstaclesPrefabs;

    public float obstacleSpawnTimer = 2f;
    public float obstacleSpeed = 1f;

    private float timeUntilObstacleSpawn;

    private void Update()
    {
        if (ScoreManager.Instance.isPlaying)
        {
            SpawnLoop();
        }
        
    }

    private void SpawnLoop()
    {
        timeUntilObstacleSpawn += Time.deltaTime;

        if (timeUntilObstacleSpawn >= obstacleSpawnTimer)
        {
            Spawn();
            timeUntilObstacleSpawn = 0f;
        }
    }

    private void Spawn()
    {
        GameObject obstacleToSpawn = obstaclesPrefabs[Random.Range(0, obstaclesPrefabs.Length)];

        GameObject spawnObstacle = Instantiate(obstacleToSpawn, transform.position, Quaternion.identity);

        Rigidbody2D obstacleRB = spawnObstacle.GetComponent<Rigidbody2D>();
        obstacleRB.velocity = Vector2.left * obstacleSpeed;
    }
}