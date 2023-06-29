using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelOver : MonoBehaviour
{
    public string nextScene = "GameOver"; // Nombre de la siguiente escena

    private int playerCount;
    /*
    private bool player1Entered; // Variable para indicar si el jugador 1 entró en la colisión
    private bool player2Entered; // Variable para indicar si el jugador 2 entró en la colisión
    */
    // Cuando un objeto colisiona
     private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {   
            playerCount++;

            if (playerCount >= 2)
            {
                SceneManager.LoadScene(nextScene);
            }
           
        }
    }
}
