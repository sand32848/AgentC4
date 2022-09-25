using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingAnimation : MonoBehaviour
{
    [SerializeField] private string startingAnimation;
    private Animator animator => GetComponent<Animator>();
    void Start()
    {
        animator.Play(startingAnimation);
    }


}
