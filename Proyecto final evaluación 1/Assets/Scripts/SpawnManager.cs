using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Determina el prefab del obst�culo
    public GameObject obstaclePrefab;

    // Determina un valor aleatorio al X
    private float randomX;

    // Determina un valor aleatorio al Y
    private float randomY;

    // Determina un valor aleatorio al Z
    private float randomZ;

    // Determina el rango del valor aleatorio
    private float rangeNumber = 200f;

    // Determina el ratio entre cada Invoke
    private float timeStart = 1f;
    private float timeInterval = 5f;


    // Start is called before the first frame update
    void Start()
    {
        // Repite la funci�n del SpawnsObstacle cada x tiempo
        InvokeRepeating("spawnObstacle", timeStart, timeInterval);
    }

    // Funci�n que spawnea un obst�culo en una posici�n aleatoria
    public void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, RandomSpawnPosition(), obstaclePrefab.transform.rotation);
    }

    // Spawnea un obst�culo en una posici�n aleatoria
    private Vector3 RandomSpawnPosition()
    {
        randomX = Random.Range(-rangeNumber, rangeNumber);
        randomY = Random.Range(0f, rangeNumber);
        randomZ = Random.Range(-rangeNumber, rangeNumber);

        return new Vector3(randomX, randomY, randomZ);
    }

}
