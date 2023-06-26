using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGen : MonoBehaviour
{

    public GameObject enemyPrefab;
    public int enemies = 0;
    private int currentEnemies = 0;
    public float timer = 0f;




    private void Start()
    {
        InvokeRepeating("CreateEnemy", timer, timer);
    }


    // Update is called once per frame
    void Update()
    {
        if (currentEnemies < enemies)
        {
            this.createEnemy();
        }
    }

    private void createEnemy()
    {
        Vector3 position = new Vector3 (transform.position.x, transform.position.y, 0);
        Instantiate(enemyPrefab, position, Quaternion.identity);
        currentEnemies++;

        if (currentEnemies >= enemies)
        {
            CancelInvoke("CreateEnemy");
        }
    }
}
