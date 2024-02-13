using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerFlipped : MonoBehaviour
{
    public GameObject[] fishFlippedPrefabs;
    private float spawnRangeX = 10f;
    private float spawnPosZUpper = 4f;
    private float spawnPosZLower = -2f;
    private float startDelayFlipped = 4f;
    private float spawnIntervalFlipped = 3f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomFishFlipped", startDelayFlipped, spawnIntervalFlipped);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomFishFlipped()
    {
        Vector3 spawnPos = new Vector3(spawnRangeX, 0, Random.Range(spawnPosZLower, spawnPosZUpper));

        int fishFlippedIndex = Random.Range(0, fishFlippedPrefabs.Length);
        Instantiate(fishFlippedPrefabs[fishFlippedIndex], spawnPos, fishFlippedPrefabs[fishFlippedIndex].transform.rotation);

    }

}
