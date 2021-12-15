using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Detecta las colisiones
    private void OnTriggerEnter(Collider otherCollider)
    {
        // Si el proyectil impacta un obstáculo
        if (gameObject.CompareTag("Projectile") && otherCollider.gameObject.CompareTag("Obstacle"))
        {
            // Destruye el proyectil
            Destroy(gameObject);

            // Destruye el obstáculo
            Destroy(otherCollider.gameObject);
        }
    }
}
