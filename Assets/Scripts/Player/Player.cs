using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{

    public PlayerStateMachine stateMachine { get; private set; }

    public PlayerIdleState idleState { get; private set; }
    public PlayerWalkState walkState { get; private set; }
    public PlayerSlideState slideState { get; private set; }


    public float SlideForce = 5f;

    



    protected override void Awake()
    {
        base.Awake();

        stateMachine = new PlayerStateMachine();

        idleState = new PlayerIdleState(this, stateMachine, "Idle");
        walkState = new PlayerWalkState(this, stateMachine, "Walk");
        slideState = new PlayerSlideState(this, stateMachine, "Slide");

    }

    protected override void Start()
    {
        base.Start();

        stateMachine.Initialize(idleState);

    }

    protected override void Update()
    {
        base.Update();

        stateMachine.currentState.Update();
    }

}
