using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YaoMing_ChaseState : EnemyState
{
    GameObject player => GameObject.FindGameObjectWithTag("Player");
    [SerializeField] private float limit;
    private float distance;
    private void Update()
    {
        distance = Vector3.Distance(transform.parent.position, player.transform.position);
    }
    public override void RunCurrentState()
    {
        navMesh.SetDestination(player.transform.position);

        if (distance <= limit)
        {
            stateManager.runState(typeof(YaoMing_AttackState));
        }
    }

    public void RunChaseState()
    {
        stateManager.runState(typeof(YaoMing_ChaseState));
    }

    public override void OnStateEnter()
    {
        navMesh.speed = 3.5f;
        animator.Play("SlowRun");
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, limit);
    }

}
