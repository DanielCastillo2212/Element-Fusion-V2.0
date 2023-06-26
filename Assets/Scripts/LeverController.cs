using UnityEngine;

public class LeverController : MonoBehaviour
{
    private Animator animator;
    public bool isOpen = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !isOpen)
        {
            this.openLever();
        }
    }

    private void openLever()
    {
        isOpen = true;
        animator.SetBool("isOpen", isOpen);
    }
}
