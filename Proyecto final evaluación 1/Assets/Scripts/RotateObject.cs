using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{

    // Velocidad de la rotación
    public float speed = 3000f;

   
    // Update is called once per frame
    void Update()
    {
        // Rota el GameObject en el eje "y" en función de la determinada
        transform.rotation *= Quaternion.Euler(0, speed * Time.deltaTime, 0);
    }
}
