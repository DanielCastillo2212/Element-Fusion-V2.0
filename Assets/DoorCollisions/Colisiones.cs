using UnityEngine;

public class Colisiones: MonoBehaviour
{
    public Transform teleportTarget; // Transform del punto de teletransporte

    private Vector2 initialPosition; // Posición inicial del personaje

    private void Start()
    {
        initialPosition = transform.position; // Almacenar la posición inicial del personaje
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Sierra"))
        {
            if (teleportTarget != null)
            {
                // Teletransportar el personaje al punto de teletransporte
                transform.position = teleportTarget.position;
            }
            else
            {
                Debug.LogWarning("El Transform del punto de teletransporte no está asignado en el script CollisionHandler.");
            }
        }
    }
}




