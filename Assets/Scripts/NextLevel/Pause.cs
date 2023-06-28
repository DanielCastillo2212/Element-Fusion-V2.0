using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pauseScreen; // Referencia al GameObject de la pantalla de pausa

    private bool isPaused = false; // Variable para controlar el estado de pausa

    // Update is called once per frame
    void Update()
    {
        // Verificar si se presiona el botón de pausa (por ejemplo, la tecla "P")
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    // Método para pausar el juego
    public void PauseGame()
    {
        Time.timeScale = 0f; // Pausar el tiempo
        isPaused = true;
        pauseScreen.SetActive(true); // Activar el GameObject de la pantalla de pausa
    }

    // Método para reanudar el juego
    public void ResumeGame()
    {
        Time.timeScale = 1f; // Reanudar el tiempo
        isPaused = false;
        pauseScreen.SetActive(false); // Desactivar el GameObject de la pantalla de pausa
    }

    // Método para volver al menú principal
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Menú"); // Cambia "MainMenu" por el nombre de tu escena principal
    }
}

