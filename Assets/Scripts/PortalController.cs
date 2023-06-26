using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    public Transform destination;
    public int jumpsPermited;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Teleport(collision.gameObject);
        }
    }


    private void Teleport(GameObject player)
    {
        Debug.Log($"Origin: {player.transform.position}");
        Vector2 vDestination = new Vector2(destination.position.x, destination.position.y);
        Debug.Log($"Destination: {vDestination}");
        player.transform.position = vDestination;
    }

}
