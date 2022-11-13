using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class YaoMing_AttackState : EnemyState
{
    GameObject player => GameObject.FindGameObjectWithTag("Player");
    [SerializeField] private float limit;
    private bool isAttacking;
    private float distance;
    private void Update()
    {
        distance = Vector3.Distance(transform.parent.position, player.transform.position);
    }

    public override void RunCurrentState()
    {

        if (distance <= limit)
       {
            if (isAttacking) return;

            int i = Random.Range(0, 3);

            if (i == 0)
            {
                animator.Play("Kick");
            }
            else if (i == 1)
            {
                animator.Play("UpperCut");
            }
            else
            {
                animator.Play("HeavyPunch");
            }

            isAttacking = true;
        }
        else
        {
             if (isAttacking) return;
            stateManager.runState(typeof(YaoMing_ChaseState));
        }
    }

    public override void OnStateEnter()
    {
        navMesh.speed = 0;
    }

    public override void OnStateExit()
    {
        isAttacking = false;
    }

    //for animator use
    public void notAttacking()
    {
        isAttacking = false;
    }


}
