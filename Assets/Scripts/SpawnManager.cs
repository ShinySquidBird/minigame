using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] crabPrefabs;
    private float spawnRangex = 20f;
    private float spawnPosZ = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangex, spawnRangex), 0, spawnPosZ);

            int crabIndex = Random.Range(0, crabPrefabs.Length);
            Instantiate(crabPrefabs[crabIndex], spawnPos, crabPrefabs[crabIndex].transform.rotation);
        }


    }
}
