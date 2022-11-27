using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manuquien_WalkState : EnemyState
{
    GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public override void RunCurrentState()
    {
        navMesh.SetDestination(player.transform.position);
    }

    public override void OnStateEnter()
    {
        navMesh.speed = 2;

        animator.Play("RobotWalk");
    }


}
