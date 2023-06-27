using UnityEngine;

public class BossHandler : MonoBehaviour
{
    public GameObject playerOne;
    public GameObject playerTwo;

    public const float DISTANCE_TO_ATTAK = 5f;

    private BossAC animController;
    private SpriteRenderer sr;

    void Start()
    {
        animController = GetComponent<BossAC>();
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
             attack(dirTwo);
        }

        else animController.setAnim(BossAC.AnimState.IDLE);


        if (disToOne < DISTANCE_TO_ATTAK)
        {
            attack(dirOne);
        }
        else animController.setAnim(BossAC.AnimState.IDLE);

    }

    private void attack(Vector3 direction)
    {

        // Rotate enemy
        if (direction.x < 0) sr.flipX = true;
        if (direction.x > 0) sr.flipX = false;

        // Move enemy to attack
        transform.position += direction * DISTANCE_TO_ATTAK * Time.deltaTime;

        // Attack
        animController.setAnim(BossAC.AnimState.ATTACK);

    }
}
