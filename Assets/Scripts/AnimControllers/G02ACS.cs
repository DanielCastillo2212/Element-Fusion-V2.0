using UnityEngine;

public class G02ACS : MonoBehaviour
{

    private Animator animator;
    private SpriteRenderer spriteRenderer;
    public int currentAnimation = 0;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        animationController();
    }

    private void animationController()
    {
        currentAnimation = 0;


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            spriteRenderer.flipX = true;
            currentAnimation = 1;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            spriteRenderer.flipX = false;
            currentAnimation = 1;
        }

        if (Input.GetKey(KeyCode.DownArrow))
            currentAnimation = 2;

        if (Input.GetKey(KeyCode.UpArrow))
            currentAnimation = 3;

        if (Input.GetKey(KeyCode.L))
            currentAnimation = 4;


        animator.SetInteger("anim", currentAnimation);

    }

}
