using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class EnemySlime : Entity
{
    public EnemySlimeStateMachine stateMachine { get; private set; }
    public EnemySlimeIdleState idleState { get; private set; }
    public EnemySlimeMoveState moveState { get; private set; }

    protected override void Awake()
    {
        base.Awake();
        stateMachine = new EnemySlimeStateMachine();

        idleState = new EnemySlimeIdleState(this, stateMachine, "Alive");
        moveState = new EnemySlimeMoveState(this, stateMachine, "Alive");

    }

    protected override void Start()
    {
        base.Start();

    }

    protected override void Update()
    {
        base.Update();

    }
}
