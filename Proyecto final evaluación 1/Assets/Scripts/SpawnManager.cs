using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Determina el prefab del obstáculo
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
    private float invokeRate = 50f;

    // Determina  el tiempo que tarda en iniciar el Invoke
    private float invokeTime = 1f;


    // Start is called before the first frame update
    void Start()
    {
        // Repite la función del SpawnsObstacle cada x tiempo
        InvokeRepeating("Obstacle", invokeTime, invokeRate);
    }

    private Vector3 RandomSpawnPosition()
    {
        randomX = Random.Range(-rangeNumber, rangeNumber);
        return new Vector3(randomX, randomY, randomZ);
    }

}
