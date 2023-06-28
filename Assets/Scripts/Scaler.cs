using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    public float scaleRate = 0f;
    private int countPlayers = 0;

    void Start()
    {
        Invoke("SearchPlayers", 1f);      
    }

    private void Update()
    {
        if (countPlayers == 2) Destroy(this);
    }

    private void SearchPlayers()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");

        foreach (var player in players)
        {
            Debug.Log(player.name);
            player.transform.localScale = new Vector3(scaleRate, scaleRate, 0);
        }

        countPlayers = players.Length;
    }

}
