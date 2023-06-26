using UnityEngine;

public class LeverController : MonoBehaviour
{
    private Animator animator;
    private bool isOpen = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.LogWarning("Collision detected");
        if (collision.CompareTag("Player"))
        {
            Debug.Log($"Player detected: Open lever");
            this.openLever();
        }
    }

    private void openLever()
    {
        isOpen = true;
        animator.SetBool("isOpen", isOpen);
    }
}
