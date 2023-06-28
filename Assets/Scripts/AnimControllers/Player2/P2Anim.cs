using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Anim : MonoBehaviour
{
    private Animator animator2;
    private SpriteRenderer spriteRenderer2;
    public int currentAnimation2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        animator2 = GetComponent<Animator>();
        spriteRenderer2 = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        animationController2();
    }

    private void animationController2()
    {
        currentAnimation2 = 0;

        //correr
        if (Input.GetKey(KeyCode.A))
        {
            spriteRenderer2.flipX = true;
            currentAnimation2 = 1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            spriteRenderer2.flipX = false;
            currentAnimation2 = 1;
        }
       
       //Deslisarse
       /*
        if (Input.GetKey(KeyCode.A))
            currentAnimation = 4;
       */

        //Saltar
        if (Input.GetKey(KeyCode.W))
            currentAnimation2 = 3;

        //Atacar

        if (Input.GetKey(KeyCode.E))
            currentAnimation2 = 4;

        /*
        //Morir
          if (Input.GetKey(KeyCode.D))
            currentAnimation = 7;
        */
    


        animator2.SetInteger("anim", currentAnimation2);

    }
}
