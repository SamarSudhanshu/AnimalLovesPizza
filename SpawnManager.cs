using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs = new GameObject[3];

    private float spawnRangeX = 10.0f;
    private float spawnPosZ = 20.0f;

    private float spawnMaxRangeZ = 10.0f;
    private float spawnMinRangeZ = 5.0f;
    private float spawnPosX = 20.0f;

    private float startDelay = 2.0f;
    private float spawnInterval = 4.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void SpawnRandomAnimal()
    {
        int animalIndex1 = Random.Range(0, animalPrefabs.Length);
        int animalIndex2 = Random.Range(0, animalPrefabs.Length);

        Vector3 rotation1 = new Vector3(0, 90, 0);
        Vector3 rotation2 = new Vector3(0, -90, 0);

        Vector3 spawnPos1 = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Vector3 spawnPos2 = new Vector3(-spawnPosX, 0, Random.Range(spawnMinRangeZ, spawnMaxRangeZ));
        Vector3 spawnPos3 = new Vector3(spawnPosX, 0, Random.Range(spawnMinRangeZ, spawnMaxRangeZ));

        Instantiate(animalPrefabs[animalIndex1], spawnPos1, animalPrefabs[animalIndex1].transform.rotation);
        Instantiate(animalPrefabs[animalIndex2], spawnPos2, Quaternion.Euler(rotation1));
        Instantiate(animalPrefabs[animalIndex2], spawnPos3, Quaternion.Euler(rotation2));
    }
}
