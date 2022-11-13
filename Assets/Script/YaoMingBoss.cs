using NodeCanvas.Framework;
using NodeCanvas.StateMachines;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEditor;
using UnityEngine;

public class YaoMingBoss : MonoBehaviour
{
    public Blackboard bb;
    private Animator animator => GetComponent<Animator>();
    public  void startFight() 
    {
        print("D");
        bb.SetVariableValue("AllowFight", true);
    }

    public bool checkAttackPass()
    {
        return animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1f;
    }
}
