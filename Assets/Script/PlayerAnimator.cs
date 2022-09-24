using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    Animator animator => GetComponent<Animator>();
    // Start is called before the first frame update

    public void playAnimation(string animationName)
    {
        animator.Play(animationName); 
    }
}
