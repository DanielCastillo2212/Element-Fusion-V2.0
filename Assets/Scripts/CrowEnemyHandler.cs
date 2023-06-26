using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;

public class CrowEnemyHandler : MonoBehaviour
{
    public GameObject playerOne;
    public GameObject playerTwo;

    private float xVelocity = 10f;
    private float yVelocity = 0f;

    public const float DISTANCE_TO_ATTAK = 5f;
    public float rotationSpeed = 5f;

    private CrowEnAC animController;
    private SpriteRenderer sr;
    private Rigidbody2D rb;

    void Start()
    {
        animController = GetComponent<CrowEnAC>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //float disToOne = Vector3.Distance(transform.position, playerOne.transform.position);
        float disToTwo = Vector3.Distance(transform.position, playerTwo.transform.position);

        //Vector3 dirOne = (playerOne.transform.position - transform.position).normalized;
        Vector3 dirTwo = (playerTwo.transform.position - transform.position).normalized;

        if (disToTwo < DISTANCE_TO_ATTAK) attack(dirTwo);
        else animController.setAnim(CrowEnAC.AnimState.IDLE);
        
        //if (disToOne < DISTANCE_TO_ATTAK) attack(dirOne);

    }

    private void attack(Vector3 direction)
    {

        // Rotate enemy
        if (direction.x < 0) sr.flipX = true;
        if (direction.x > 0) sr.flipX = false;

        // Move enemy to attack
        transform.position += direction * DISTANCE_TO_ATTAK * Time.deltaTime;

        // Attack
        animController.setAnim(CrowEnAC.AnimState.ATTACK);

    }

}
