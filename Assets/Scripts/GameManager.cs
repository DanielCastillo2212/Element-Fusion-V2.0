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
        playerLogOne = playerOne.GetComponent<PlayerLog>();

        textMeshProTwo = logTwo.GetComponent<TextMeshProUGUI>();
        playerLogTwo = playerTwo.GetComponent<PlayerLog>();
    } 

    // Update is called once per frame
    void Update() 
    {
        textMeshProOne.text = $"Player One [Points: {playerLogOne.Points} Lifes: {playerLogOne.Lifes}]";
        textMeshProTwo.text = $"Player Two [Points: {playerLogTwo.Points} Lifes: {playerLogTwo.Lifes}]";
    }
}
