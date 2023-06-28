using UnityEngine;


public class CrowEnemyHandler : MonoBehaviour
{
    public GameObject playerOne;
    public GameObject playerTwo;

    public float DISTANCE_TO_ATTAK = 5f;
    public bool attacking = false;
    public float attackInterval = 1f;
    public float attackTimer = 0f;

    private CrowEnAC animController;
    private SpriteRenderer sr;

    void Start()
    {
        animController = GetComponent<CrowEnAC>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {   

        float disToOne = Vector3.Distance(transform.position, playerOne.transform.position);
        float disToTwo = Vector3.Distance(transform.position, playerTwo.transform.position);

        Vector3 dirOne = (playerOne.transform.position - transform.position).normalized;
        Vector3 dirTwo = (playerTwo.transform.position - transform.position).normalized;

        if (disToTwo < DISTANCE_TO_ATTAK)
        {
            attacking = true;
            attack(dirTwo);
        }

        else
        {
            animController.setAnim(CrowEnAC.AnimState.IDLE);
            attacking= false;
        }
        
        if (disToOne < DISTANCE_TO_ATTAK)
        {
            attack(dirOne);
            attacking = true;
        }
        else
        {
            animController.setAnim(CrowEnAC.AnimState.IDLE);
            attacking= false;
        }

    }

    private void attack(Vector3 direction)
    {

        // Rotate enemy
        if (direction.x < 0) sr.flipX = true;
        if (direction.x > 0) sr.flipX = false;

        // Move enemy to attack
        animController.setAnim(CrowEnAC.AnimState.WALK);
        transform.position += direction * DISTANCE_TO_ATTAK * Time.deltaTime;

        // Attack
        animController.setAnim(CrowEnAC.AnimState.ATTACK);
    }
}
