using UnityEngine;

public class LeverController : MonoBehaviour
{
    private Animator animator;
    public bool isOpen = false;
    private AudioSource audioSource;

    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
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
        audioSource.Play();
        animator.SetBool("isOpen", isOpen);
    }
}
