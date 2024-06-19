using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 5;
    private CharacterController characterController;

    public Animator animator;

    public bool isEnableMove = true;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }


    void Update()
    {
       if (isEnableMove)
        {
            Vector3 movement;

            float inputHorizontal = speed * Input.GetAxis("Horizontal") * Time.deltaTime;


            Vector3 right = transform.right;


            movement = right * inputHorizontal;



            characterController.Move(movement);

            if (inputHorizontal == 0)
            {
                animator.SetBool("Ismoving", false);
            }

            else if (inputHorizontal < 0)
            {
                animator.SetBool("Ismoving", true);

                animator.SetFloat("float_moveHorizontal", inputHorizontal);
            }
        }
    }

   public void gameEnd()
    {
        isEnableMove = false;
        animator.SetTrigger("GameOver");
    }
}
    

