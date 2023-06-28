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

    /*public GameObject[] characters2;
    public Transform playerStartPosition2;
    public string menuScene2 = "Character Selection Menu";
    private string selectedCharacterDataName2 = "SelectedCharacter";
    int selectedCharacter2;
    public GameObject playerObject2;*/

    private CinemachineVirtualCamera vcamOne; // Referencia al componente CinemachineVirtualCamera

    // Start is called before the first frame update
    void Start()
    {
        selectedCharacter = PlayerPrefs.GetInt(selectedCharacterDataName, 0);
        playerObject = Instantiate(characters[selectedCharacter], playerStartPosition.position, characters[selectedCharacter].transform.rotation);

        GameObject vcamObject = GameObject.Find("VCam01");

       vcamOne = vcamObject.GetComponent<CinemachineVirtualCamera>();
        vcamOne.Follow = playerObject.transform;


         GameObject[] enemies = GameObject.FindGameObjectsWithTag("CrowEnemy");

        foreach(var enemy in enemies){
        var enemyHandler = enemy.GetComponent<CrowEnemyHandler>();
        enemyHandler.playerOne = playerObject;
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

