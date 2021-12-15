using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Detecta las colisiones
    private void OnCollisionEnter(Collision otherCollision)
    {
        // Si el proyectil impacta un obstáculo
        if (gameObject.CompareTag("Obstacle") && otherCollision.gameObject.CompareTag("Projectile"))
        {
            // Destruye el proyectil
            Destroy(gameObject);

            // Destruye el obstáculo
            Destroy(otherCollision.gameObject);
        }
    }
}
