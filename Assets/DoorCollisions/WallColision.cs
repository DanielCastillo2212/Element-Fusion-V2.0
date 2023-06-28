using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallColision : MonoBehaviour
{

    private int playerCount;

    // Cuando un objeto colisiona
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerCount++;
            
            if (playerCount >= 2)
            {
                // Cambiar el objeto a un trigger
                collision.collider.isTrigger = true;
            }
        }
    }
}
