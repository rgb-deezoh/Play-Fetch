using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    //private float startDelay = 1.0f;
    private float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
        SpawnRandomBall();
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // Instantiate ball at random spawn location
        int randomBalls = Random.Range(0, ballPrefabs.Length);

        // This does the actual spawning of the balls
        Instantiate(ballPrefabs[randomBalls], spawnPos, ballPrefabs[randomBalls].transform.rotation);

        // Do the random interval selection
        spawnInterval = Random.Range(3.0f, 5.0f);

        // This makes the method be called after every frame
        Invoke("SpawnRandomBall", spawnInterval);
    }

}
