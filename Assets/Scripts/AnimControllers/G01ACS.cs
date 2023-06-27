using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G01ACS : MonoBehaviour
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
        currentAnimation = 1;

        //correr
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            spriteRenderer.flipX = true;
            currentAnimation = 3;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            spriteRenderer.flipX = false;
            currentAnimation = 3;
        }
       
       //Deslisarse
       /*
        if (Input.GetKey(KeyCode.A))
            currentAnimation = 4;
       */

        //Saltar
        if (Input.GetKey(KeyCode.UpArrow))
            currentAnimation = 6;

        //Atacar

        if (Input.GetKey(KeyCode.X))
            currentAnimation = 5;

        /*
        //Morir
          if (Input.GetKey(KeyCode.D))
            currentAnimation = 7;
        */
    


        animator.SetInteger("anim", currentAnimation);

    }
}
