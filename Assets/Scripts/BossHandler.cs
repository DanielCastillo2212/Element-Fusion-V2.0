using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class BossHandler : MonoBehaviour
{
    public GameObject playerOne;
    public GameObject playerTwo;

    public float DISTANCE_TO_ATTAK = 5f;

    private BossAC animController;
    private SpriteRenderer sr;
    private AudioSource audioSource;

    void Start()
    {
        animController = GetComponent<BossAC>();
        sr = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
        Invoke("FindPlayers", .5f);
    }


    private void FindPlayers()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");

        if (players.Length == 2)
        {
            playerOne = players[0];
            playerTwo = players[1];
        }
        else return;

        CancelInvoke("FindPlayers");
    }

    // Update is called once per frame
    void Update()
    {

        if (playerOne == null || playerTwo == null) return;

        float disToOne = Vector3.Distance(transform.position, playerOne.transform.position);
        float disToTwo = Vector3.Distance(transform.position, playerTwo.transform.position);

        Vector3 dirOne = (playerOne.transform.position - transform.position).normalized;
        Vector3 dirTwo = (playerTwo.transform.position - transform.position).normalized;

        if (disToTwo < DISTANCE_TO_ATTAK)
             attack(dirTwo);

        else
            animController.setAnim(BossAC.AnimState.IDLE);
            


        if (disToOne < DISTANCE_TO_ATTAK)
            attack(dirOne);

        else
            animController.setAnim(BossAC.AnimState.IDLE);

    }

    private void attack(Vector3 direction)
    {
        if (!audioSource.isPlaying)
            audioSource.Play();

        // Rotate enemy
        if (direction.x < 0) sr.flipX = true;
        if (direction.x > 0) sr.flipX = false;

        // Move enemy to attack
        transform.position += direction * DISTANCE_TO_ATTAK * Time.deltaTime;

        // Attack
        animController.setAnim(BossAC.AnimState.ATTACK);
    }
}
