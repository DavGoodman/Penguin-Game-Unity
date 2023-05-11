using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : State
{
    protected Player player;
    protected PlayerStateMachine stateMachine;
    protected Rigidbody2D rb;


    private string animBoolName;

    public PlayerState(Player player, PlayerStateMachine stateMachine, string animBoolName)
    {
        this.player = player;
        this.stateMachine = stateMachine;
        this.animBoolName = animBoolName;
    }

    public override void Enter()
    {
        base.Enter();
        rb = player.rb;
        player.anim.SetBool(animBoolName, true);
    }
 
    public override void Update()
    {
        base.Update();
    }

    public override void Exit()
    {
        base.Exit();

        player.anim.SetBool(animBoolName, false);

    }
}
