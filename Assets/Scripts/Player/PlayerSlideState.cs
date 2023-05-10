using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSlideState : PlayerState
{
    public PlayerSlideState(Player player, PlayerStateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();

        rb.sharedMaterial.friction = 0f;
        rb.drag = 0;
        rb.velocity = new Vector2(player.facingDir * player.SlideForce, rb.velocity.y);

    }

    public override void Exit()
    {
        base.Exit();
        rb.drag = 15;
        rb.sharedMaterial.friction = 0.4f;
    }

    public override void Update()
    {
        base.Update();
        
        if (player.rb.velocity.x < 1 && player.rb.velocity.x > -1)
            player.stateMachine.ChangeState(player.idleState);
    }
}
