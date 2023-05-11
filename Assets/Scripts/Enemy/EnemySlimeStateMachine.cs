using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySlimeStateMachine 
{
    public EnemySlimeState currentState { get; private set; }

    public void Initialize(EnemySlimeState startState)
    {
        currentState = startState;
        currentState.Enter();
    }

    public void ChangeState(EnemySlimeState newState)
    {
        currentState.Exit();
        currentState = newState;
        currentState.Enter();
    }
}
