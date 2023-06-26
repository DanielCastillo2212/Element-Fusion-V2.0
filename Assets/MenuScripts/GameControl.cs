using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;

public class GameControl : MonoBehaviour
{
    public GameObject[] characters;
    public Transform playerStartPosition;
    public string menuScene = "Character Selection Menu";
    private string selectedCharacterDataName = "SelectedCharacter";
    int selectedCharacter;
    public GameObject playerObject;

    private CinemachineVirtualCamera virtualCamera; // Referencia al componente CinemachineVirtualCamera

    // Start is called before the first frame update
    void Start()
    {
        selectedCharacter = PlayerPrefs.GetInt(selectedCharacterDataName, 0);
        playerObject = Instantiate(characters[selectedCharacter], playerStartPosition.position, characters[selectedCharacter].transform.rotation);

        virtualCamera = FindObjectOfType<CinemachineVirtualCamera>(); // Obtener referencia al componente CinemachineVirtualCamera

        if (virtualCamera != null)
        {
            virtualCamera.Follow = playerObject.transform; // Asignar el objeto del jugador a la propiedad Follow de CinemachineVirtualCamera
        }
        else
        {
            Debug.LogWarning("CinemachineVirtualCamera not found in the scene. Make sure you have a CinemachineVirtualCamera component attached to a camera.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ReturnToMainMenu();
        }
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("SceneMain");
    }
}

