using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Collisions : MonoBehaviour
{
    public Transform teleportTarget; // Transform del punto de teletransporte

    private void Start()
    {

        GameObject tp = GameObject.Find("RespTwo");
        teleportTarget = tp.transform;
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
