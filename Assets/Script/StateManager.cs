using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StateManager : MonoBehaviour
{
    public State currentState;
    public List<State> stateList = new List<State>();
    [SerializeField] private GameObject stateHolder;
    [SerializeField] private bool debug = false;

    private void Start()
    {
        initializeState();
    }

    void Update()
    {
        RunStateMachine();
    }

    private void RunStateMachine()
    {
        currentState?.RunCurrentState();
    }

    public void SwitchToTheNextState(State nextState)
    {
        currentState = nextState;
        currentState.OnStateEnter();
    }
    public void runState(System.Type stateType)
    {
        currentState.StopAllCoroutines();
        currentState.OnStateExit();
        if (debug) Debug.Log($"Change state from {currentState} to {stateType}");
        SwitchToTheNextState(getState(stateType));
    }

    public void runState(State stateType)
    {
        currentState.StopAllCoroutines();
        currentState.OnStateExit();
        if (debug) Debug.Log($"Change state from {currentState} to {stateType}");
        currentState = stateType;
        currentState.OnStateEnter();
    }

    public void initializeState()
    {
        Component[] stateArray;
        stateArray = stateHolder.GetComponents(typeof(State));

        for (var i = 0; i < stateArray.Length; i++)
        {
            stateList.Add(stateArray[i] as State);
        }
    }

    public State getState(System.Type stateType)
    {
        State state = null;

        for (var i = 0; i < stateList.Count; i++)
        {
            if (stateList[i].GetType() == stateType)
            {
                state = stateList[i];
                return state;
            }
        }

        if(debug) Debug.Log($"{stateType} does not exist, call from {currentState}");
        return null;
    }
}
