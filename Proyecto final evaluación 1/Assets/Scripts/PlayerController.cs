using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // El jugador empieza en esta posici�n
    private Vector3 defaultPosition = new Vector3(0f, 100f, 0f);

    // Velocidad de movimiento
    private float speed = 50f;

    // Rango m�ximo de movimiento
    private float range = 200f;

    // Controles verticales y horizontales
    private float verticalInput;
    private float horizontalInput;

    // Almacena el prefab del proyectil
    public GameObject projectilePrefab;

    // Cantidad de monedas
    private int totalCoins = 0;

    // Cantidad m�ximas de monedas
    private int maxCoins = 10;


    // Start is called before the first frame update
    void Start()
    {
        // Posiciona al jugador en la posici�n inicial
        transform.position = defaultPosition;
    }

    // Update is called once per frame
    void Update()
    {
        // Con el Ctrl el player dispara un proyectil
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }

        // Controles verticales y horizontales
        verticalInput = -Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // Mueve el helicoptero hacia delante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Rota el helicoptero dependiendo del eje
        transform.Rotate(Vector3.up * speed * Time.deltaTime * horizontalInput);
        transform.Rotate(Vector3.right * speed * Time.deltaTime * verticalInput);
    }
}
