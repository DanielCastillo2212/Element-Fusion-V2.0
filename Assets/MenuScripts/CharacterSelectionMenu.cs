using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelectionMenu : MonoBehaviour
{
    public GameObject[] playerObjects;
    public int selectedCharacter = 0;

    public string gameScene = "Character Selection Scene";

    public string selectedCharacterDataName = "SelectedCharacter";

    public GameObject[] playerObjects2;
    public int selectedCharacter2 = 0;

    public string gameScene2 = "Character Selection Scene";

    public string selectedCharacterDataName2 = "SelectedCharacter";

    // Start is called before the first frame update
    void Start()
    {
        HideAllCharacters();

        selectedCharacter = PlayerPrefs.GetInt(selectedCharacterDataName, 0);

        playerObjects[selectedCharacter].SetActive(true);

        HideAllCharacters2();
        selectedCharacter2 = PlayerPrefs.GetInt(selectedCharacterDataName2, 0);

        playerObjects2[selectedCharacter2].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void HideAllCharacters(){
        foreach(GameObject g in playerObjects){
            g.SetActive(false);
        }
    }

    private void HideAllCharacters2(){
        foreach(GameObject g in playerObjects2){
            g.SetActive(false);
        }
    }

    public void NextCharacter(){
        playerObjects[selectedCharacter].SetActive(false);
        selectedCharacter++;
        if(selectedCharacter >= playerObjects.Length){
            selectedCharacter = 0;
        }
        playerObjects[selectedCharacter].SetActive(true);
    }

    public void NextCharacter2(){
        playerObjects2[selectedCharacter2].SetActive(false);
        selectedCharacter2++;
        if(selectedCharacter2 >= playerObjects2.Length){
            selectedCharacter2 = 0;
        }
        playerObjects2[selectedCharacter2].SetActive(true);
    }

    public void PreviusCharacter(){
        playerObjects[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if(selectedCharacter < 0){
            selectedCharacter = playerObjects.Length-1;
        }
        playerObjects[selectedCharacter].SetActive(true);
    }

    public void PreviusCharacter2(){
        playerObjects2[selectedCharacter2].SetActive(false);
        selectedCharacter2--;
        if(selectedCharacter2 < 0){
            selectedCharacter2 = playerObjects2.Length-1;
        }
        playerObjects2[selectedCharacter2].SetActive(true);
    }

    /*
   public void OpenLevel1(){
        PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
        SceneManager.LoadScene("Level_01");
    }

    public void OpenLevel2(){
        PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
        SceneManager.LoadScene("Level_02");
    }

    public void OpenLevel3(){
        PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
        SceneManager.LoadScene("Level_01");
    }
    */

    public void OpenLevel1()
    {
        PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
        PlayerPrefs.SetInt(selectedCharacterDataName2, selectedCharacter2);
        //PlayerPrefs.SetInt(characterSelectionMenuPlayer2.selectedCharacterDataName2, characterSelectionMenuPlayer2.selectedCharacter2);
        SceneManager.LoadScene("Level_01");
    }

    public void OpenLevel2()
    {
        PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
        SceneManager.LoadScene("Level_02");
    }

    public void OpenLevel3()
    {
        PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
        SceneManager.LoadScene("Level_01");
    }



}
