using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    public Transform destination;
    public int jumpsPermited;
    public bool active = true;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && active)
        {
            Teleport(collision.gameObject);
        }
    }


    private void Teleport(GameObject player)
    {
        Vector2 vDestination = new Vector2(destination.position.x, destination.position.y);
        player.transform.position = vDestination;
    }

}
