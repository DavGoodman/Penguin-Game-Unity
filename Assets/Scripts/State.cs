using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State 
{


    protected float xInput;
    protected float yInput;


    protected float stateTimer;
    protected bool triggerCalled;


    public virtual void Enter()
    {
        triggerCalled = false;
    }

    public virtual void Update()
    {
        stateTimer -= Time.deltaTime;
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");
    }

    public virtual void Exit()
    {

    }
}
