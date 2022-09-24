using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State : MonoBehaviour
{
    protected StateManager stateManager;
    public virtual void Start()
    {
        stateManager = transform.parent.GetComponent<StateManager>();
    }
    public abstract void RunCurrentState();

    private void OnEnable()
    {
        stateManager = transform.parent.GetComponent<StateManager>();
    }

    public virtual void OnStateEnter()
    {

    }

    public virtual void OnStateExit()
    {

    }


}
