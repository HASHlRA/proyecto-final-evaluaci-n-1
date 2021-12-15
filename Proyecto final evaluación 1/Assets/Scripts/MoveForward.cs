using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Velocidad del proyectil
    private float speed = 500f;


    // Update is called once per frame
    void Update()
    {
        // Movimiento del proyectil
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
