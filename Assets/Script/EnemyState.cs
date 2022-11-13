using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class EnemyState : State
{
	protected NavMeshAgent navMesh;
	protected Animator animator;
	
	private void OnEnable()
	{
		stateManager = transform.parent.GetComponent<StateManager>();
		navMesh = transform.parent.GetComponent<NavMeshAgent>();
		animator = transform.parent.GetComponent<Animator>();
		//enemyAI = transform.parent.GetComponent<EnemyAI>();
		//enemyMovement = transform.parent.GetComponent<EnemyMovement>();
		//phaseController = transform.parent.GetComponent<PhaseController>();
		//audioPlayer = transform.parent.GetComponent<AudioPlayers>();
	}
}
