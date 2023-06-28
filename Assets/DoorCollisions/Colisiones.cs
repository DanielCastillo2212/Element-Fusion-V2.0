using UnityEngine;

public class Colisiones: MonoBehaviour
{
    private Transform teleportTarget; // Transform del punto de teletransporte


    private void Start()
    {
        GameObject tp = GameObject.Find("RespOne");
        teleportTarget = tp.transform;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SierraP2"))
        {
            if (teleportTarget != null)
            {
                Debug.Log($"Tp to {teleportTarget}");
                // Teletransportar el personaje al punto de teletransporte
                transform.position = new Vector3(
                    teleportTarget.position.x,
                    teleportTarget.position.y, 0);
            }
            else
            {
                Debug.LogWarning("El Transform del punto de teletransporte no está asignado en el script CollisionHandler.");
            }
        }
    }
}




