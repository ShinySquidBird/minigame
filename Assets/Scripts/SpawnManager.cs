using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] fishPrefabs;
    private float spawnRangeX = 10f;
    private float spawnPosZUpper = 4f;
    private float spawnPosZLower = -2f;
    private float startDelay = 2f;
    private float spawnInterval = 3f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomFish", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomFish()
    {
        Vector3 spawnPos = new Vector3(-spawnRangeX, 0, Random.Range(spawnPosZLower, spawnPosZUpper));

        int fishIndex = Random.Range(0, fishPrefabs.Length);
        Instantiate(fishPrefabs[fishIndex], spawnPos, fishPrefabs[fishIndex].transform.rotation);

    }

}
