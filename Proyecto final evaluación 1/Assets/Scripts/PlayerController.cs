using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // El jugador empieza en esta posición
    private Vector3 defaultPosition = new Vector3(0f, 100f, 0f);

    // Velocidad de movimiento
    private float speed = 25f;

    // Rango máximo de movimiento
    private float xRange = 200f;

    // Controles verticales y horizontales
    private float verticalInput;
    private float horizontalInput;

    // Almacena el prefab del proyectil
    public GameObject projectilePrefab;

    // Cantidad de monedas
    private int totalCoins = 0;

    // Cantidad máximas de monedas
    private int maxCoins = 10;


    // Start is called before the first frame update
    void Start()
    {
        // Posiciona al jugador en la posición inicial
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

        // Límite de pantalla derecho
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y,
                transform.position.z);
        }

        // Límite de pantalla izquierdo
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y,
                transform.position.z);
        }

        // Comprueba las colisiones del Player con los gameObjects
        void OnCollisionEnter(Collision otherCollision)
        {
            // Si colisiona contra un obstáculo
            if (otherCollision.gameObject.CompareTag("Obstacle"))
            {
                // Muestra el mensaje por consola y para el juego
                Debug.Log("GAME OVER");
                Time.timeScale = 0f;
            }

            // Si colisiona contra una moneda
            if (otherCollision.gameObject.CompareTag("Coin"))
            {
                // Elimina (recoge) la moneda
                Destroy(otherCollision.gameObject);

                // Suma el total de monedas obetenidas
                totalCoins++;

                // Si se obtiene todas las monedas, para el juego y ganas
                if (totalCoins >= maxCoins)
                {
                    Debug.Log("¡Felicidades, has recogido todas las monedas!");
                    Time.timeScale = 0f;
                }
            }
        }


    }
}