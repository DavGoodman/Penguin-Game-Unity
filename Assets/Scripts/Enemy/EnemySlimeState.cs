using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySlimeState : State
{
    EnemySlime enemySlime;
    EnemySlimeStateMachine stateMachine;
    Rigidbody2D rb;

    private string animBoolName;


    public EnemySlimeState(EnemySlime enemySlime, EnemySlimeStateMachine stateMachine, string animBoolName)
    {
        this.enemySlime = enemySlime;
        this.stateMachine = stateMachine;
        this.animBoolName = animBoolName;
    }

    public override void Enter()
    {
        base.Enter();
        rb = enemySlime.rb;
        enemySlime.anim.SetBool(animBoolName, true);
    }

    public override void Update()
    {
        base.Update();
    }

    public override void Exit()
    {
        base.Exit();
        enemySlime.anim.SetBool(animBoolName, false);
    }
}
