using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yaoming_HurtState : EnemyState
{
    [SerializeField] private int health = 3;
    [SerializeField] private float waitTime;
    private float _waitTime;
    private bool isLock;

    private void Start()
    {
        _waitTime = waitTime;
    }
    public override void RunCurrentState()
    {
        waitTime -= Time.deltaTime;

        if(waitTime <= 0)
        {
            if (health <= 0)
            {
                stateManager.runState(typeof(YaoMing_DefeatState));
            }
            else
            {
                stateManager.runState(typeof(YaoMing_ChaseState));
            }

            waitTime = _waitTime;
        }
    }

    public override void OnStateEnter()
    {
        navMesh.speed = 0;

        animator.Play("Hurt");

        health -= 1;

    }

    public override void OnStateExit()
    {
        waitTime = _waitTime;
    }

    public void EnterHurtState()
    {
        if (isLock) return;
        stateManager.runState(typeof(Yaoming_HurtState));
    }

    public void SetLock(bool _lock)
    {
        isLock = _lock;
    }
}
