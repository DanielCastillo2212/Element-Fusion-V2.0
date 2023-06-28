using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelPortal : MonoBehaviour
{
    public string nextScene = "Level_02"; // Nombre de la siguiente escena

    private bool player1Entered; // Variable para indicar si el jugador 1 entró en la colisión
    private bool player2Entered; // Variable para indicar si el jugador 2 entró en la colisión

    // Cuando un objeto colisiona
     private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {   
            Debug.Log("Puerta abierta");
            player1Entered=true;

            if (player1Entered && player2Entered)
            {
                SceneManager.LoadScene(nextScene);
            }
           
        }
        if (collision.gameObject.CompareTag("Player2"))
        {   
            Debug.Log("Puerta abierta2");
            player2Entered=true;

            if (player1Entered && player2Entered)
            {
                SceneManager.LoadScene(nextScene);
            }
           
        }
    }


}


