using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySlimeIdleState : EnemySlimeState
{
    public EnemySlimeIdleState(EnemySlime enemySlime, EnemySlimeStateMachine stateMachine, string animBoolName) : base(enemySlime, stateMachine, animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
    }
}
