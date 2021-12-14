using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{

    // Velocidad de la rotaci�n
    public float speed = 3000f;

   
    // Update is called once per frame
    void Update()
    {
        // Rota el GameObject en el eje "x" en funci�n de la determinada
        transform.Rotate(new Vector3(90f, 0f, 0f) * Time.deltaTime);
    }
}
