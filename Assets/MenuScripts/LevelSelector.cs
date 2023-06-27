using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OpenLevel1(){
        SceneManager.LoadScene("Level_01");
    }

    public void OpenLevel2(){
        SceneManager.LoadScene("Level_02");
    }

    public void OpenLevel3(){
        SceneManager.LoadScene("Level_03");
    }

    public void OpenSelection(){
        SceneManager.LoadScene("Menú_Play");
    }
}
