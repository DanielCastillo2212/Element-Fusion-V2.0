using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelectionMenuPlayer2 : MonoBehaviour
{
    public GameObject[] playerObjects2;
    public int selectedCharacter2 = 0;

    public string gameScene2 = "Character Selection Scene";

    public string selectedCharacterDataName2 = "SelectedCharacter2";
// Start is called before the first frame update
void Start()
{
     HideAllCharacters2();
        selectedCharacter2 = PlayerPrefs.GetInt(selectedCharacterDataName2, 0);

        playerObjects2[selectedCharacter2].SetActive(true);
}

// Update is called once per frame
void Update()
{
    
}

private void HideAllCharacters2(){
        foreach(GameObject g in playerObjects2){
            g.SetActive(false);
        }
    }

 public void NextCharacter2(){
        playerObjects2[selectedCharacter2].SetActive(false);
        selectedCharacter2++;
        if(selectedCharacter2 >= playerObjects2.Length){
            selectedCharacter2 = 0;
        }
        playerObjects2[selectedCharacter2].SetActive(true);
    }

public void PreviusCharacter2(){
        playerObjects2[selectedCharacter2].SetActive(false);
        selectedCharacter2--;
        if(selectedCharacter2 < 0){
            selectedCharacter2 = playerObjects2.Length-1;
        }
        playerObjects2[selectedCharacter2].SetActive(true);
    }

    public void GuardarPlayer2(){
        PlayerPrefs.SetInt(selectedCharacterDataName2, selectedCharacter2);
    }

}
