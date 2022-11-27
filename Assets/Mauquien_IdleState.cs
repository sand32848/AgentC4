using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mauquien_IdleState : EnemyState
{
    [SerializeField] private bool enterState;
    [SerializeField] private float timer;

    private void Start()
    {
        enterState = true;
    }

    public override void RunCurrentState()
    {
        if (!enterState) return;

        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            stateManager.runState(typeof(Manuquien_WalkState));
        }
    }

    public override void OnStateEnter()
    {
        enterState = true;
    }
}
