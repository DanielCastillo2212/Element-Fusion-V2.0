using UnityEngine;

public class PlayerLog : MonoBehaviour
{
    public int Points { get; set; } = 0;
    public int Lifes { get; set; } = 5;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("CrowEnemy"))
        {
            var crowController = collision.gameObject.GetComponent<CrowEnemyHandler>();
            
            if (crowController.attacking)
                Lifes--;

            else
            {
                Destroy(collision.gameObject);
                Points++;
            }
        }
    }
}
