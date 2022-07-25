using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStateLoopBehavior : StateMachineBehaviour
{
    public string s;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetInteger(s, animator.GetInteger(s) - 1);
    }

}