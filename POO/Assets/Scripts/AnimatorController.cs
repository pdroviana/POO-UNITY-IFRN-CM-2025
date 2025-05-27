using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool("isWalking");
        bool fowardPressed = Input.GetKey(KeyCode.W);
        bool leftPressed = Input.GetKey(KeyCode.A);
        bool rightPressed = Input.GetKey(KeyCode.D);

        if (!isWalking && fowardPressed)
        {
            animator.SetBool("isWalking", true);
        }

        if (isWalking && !fowardPressed)
        {
            animator.SetBool("isWalking", false);
        }
        
        if (!isWalking && leftPressed)
        {
            animator.SetBool("isWalking", true);
        }

        if (isWalking && !leftPressed)
        {
            animator.SetBool("isWalking", false);
        }
        
        if (!isWalking && rightPressed)
        {
            animator.SetBool("isWalking", true);
        }

        if (isWalking && !rightPressed)
        {
            animator.SetBool("isWalking", false);
        }
    }
}
