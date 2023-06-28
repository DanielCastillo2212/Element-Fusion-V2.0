using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject playerOne;
    public GameObject logOne;
    private PlayerLog playerLogOne;
    private TextMeshProUGUI textMeshProOne;

    public GameObject playerTwo;
    public GameObject logTwo;
    private TextMeshProUGUI textMeshProTwo;
    private PlayerLog playerLogTwo;


    void Start()
    {
        textMeshProOne = logOne.GetComponent<TextMeshProUGUI>();
        textMeshProTwo = logTwo.GetComponent<TextMeshProUGUI>();
        Invoke("Setup", 1f);
    } 

    // Update is called once per frame
    void Update() 
    {
        if (playerLogOne != null)
            textMeshProOne.text = $"Player One [Points: {playerLogOne.Points} Lifes: {playerLogOne.Lifes}]";

        if (playerLogTwo != null)
            textMeshProTwo.text = $"Player Two [Points: {playerLogTwo.Points} Lifes: {playerLogTwo.Lifes}]";
    }

    private void Setup()
    {

        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");

        if (players.Length == 2)
        {
            playerOne = players[0];
            playerTwo = players[1];
        }
        else return;

        playerLogOne = playerOne.GetComponent<PlayerLog>();
        playerLogTwo = playerTwo.GetComponent<PlayerLog>();
        CancelInvoke("Setup");
    }
}
