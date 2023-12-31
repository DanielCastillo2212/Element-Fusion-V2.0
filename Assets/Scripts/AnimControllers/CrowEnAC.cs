using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowEnAC : MonoBehaviour
{

    public enum AnimState
    {
        IDLE, WALK, ATTACK, DAMAGE, DEATH
    }


    private Animator animator;
    private AnimState currentAnimation;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        currentAnimation = AnimState.IDLE;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetInteger("anim", (int) currentAnimation);
    }

    public void setAnim(AnimState state)
    {
        currentAnimation = state;
    }

}
