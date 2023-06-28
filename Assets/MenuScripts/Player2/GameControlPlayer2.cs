using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;

public class GameControlPlayer2 : MonoBehaviour
{
    public GameObject[] characters2;
    public Transform playerStartPosition2;
    public string menuScene2 = "Character Selection Menu";
    private string selectedCharacterDataName2 = "SelectedCharacter2";
    int selectedCharacter2;
    public GameObject playerObject2;
    private CinemachineVirtualCamera vcamTwo; // Referencia al componente CinemachineVirtualCamera

    // Start is called before the first frame update
    void Start()
    {
        selectedCharacter2 = PlayerPrefs.GetInt(selectedCharacterDataName2, 0);
        playerObject2 = Instantiate(characters2[selectedCharacter2], playerStartPosition2.position, characters2[selectedCharacter2].transform.rotation);

        GameObject vcamObject = GameObject.Find("VCam02");

        vcamTwo = vcamObject.GetComponent<CinemachineVirtualCamera>(); // Obtener referencia al componente CinemachineVirtualCamera
        vcamTwo.Follow = playerObject2.transform;

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("CrowEnemy");

        foreach (var enemy in enemies)
        {
            var enemyHandler = enemy.GetComponent<CrowEnemyHandler>();
            enemyHandler.playerTwo = playerObject2;
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
