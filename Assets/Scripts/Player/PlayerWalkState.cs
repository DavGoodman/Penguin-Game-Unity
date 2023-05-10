using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkState : PlayerState
{
    public PlayerWalkState(Player player, PlayerStateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
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
        player.SetVelocity(xInput * player.moveSpeed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        { 
            player.stateMachine.ChangeState(player.slideState);
        }

        if (xInput == 0)
            player.stateMachine.ChangeState(player.idleState);
        
    }
}
