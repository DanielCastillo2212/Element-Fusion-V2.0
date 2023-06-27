using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelectionMenuPlayer2 : MonoBehaviour
{
    public GameObject[] playerObjects;
public int selectedCharacter2 = 0;

public string gameScene = "Character Selection Scene";

public string selectedCharacterDataName2 = "SelectedCharacter";
// Start is called before the first frame update
void Start()
{
    HideAllCharacters();

    selectedCharacter2 = PlayerPrefs.GetInt(selectedCharacterDataName2, 0);

    playerObjects[selectedCharacter2].SetActive(true);
}

// Update is called once per frame
void Update()
{
    
}

private void HideAllCharacters()
{
    foreach(GameObject g in playerObjects)
    {
        g.SetActive(false);
    }
}

public void NextCharacter()
{
    playerObjects[selectedCharacter2].SetActive(false);
    selectedCharacter2++;
    if(selectedCharacter2 >= playerObjects.Length)
    {
        selectedCharacter2 = 0;
    }
    playerObjects[selectedCharacter2].SetActive(true);
}

public void PreviusCharacter()
{
    playerObjects[selectedCharacter2].SetActive(false);
    selectedCharacter2--;
    if(selectedCharacter2 < 0)
    {
        selectedCharacter2 = playerObjects.Length - 1;
    }
    playerObjects[selectedCharacter2].SetActive(true);
}

}
