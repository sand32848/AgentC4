using NodeCanvas.DialogueTrees;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class YaoMing_DefeatState : EnemyState
{
    [SerializeField] private GameObject deathSpot;
    [SerializeField] private RotateTo rotateTo;
    [SerializeField] private DialogueTreeController dialogueTree;
    private Yaoming_HurtState hurtState => GetComponent<Yaoming_HurtState>();
    private bool started;
    public override void RunCurrentState()
    {
  
        navMesh.SetDestination(deathSpot.transform.position);

        if (started) return;

        if (!navMesh.pathPending)
        {
            if (navMesh.remainingDistance <= navMesh.stoppingDistance)
            {
                if (!navMesh.hasPath || navMesh.velocity.sqrMagnitude == 0f)
                {
                    rotateTo.rotate();
                    dialogueTree.StartDialogue();
                    animator.Play("HurtIdle");
                    started = true;
                    hurtState.SetLock(true);

                }
            }
        }
    }

    public override void OnStateEnter()
    {
        animator.Play("HurtWalk");
        navMesh.speed = 2.5f;
    }
}
