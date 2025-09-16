using UnityEngine;

public class RenderText : StateMachineBehaviour
{
    [Tooltip("The name of the child GameObject to set active.")]
    public string childToActivate;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // Get the parent GameObject from the Animator component.
        GameObject parentObject = animator.gameObject;

        // Find the specific child by name.
        Transform childTransform = parentObject.transform.Find(childToActivate);

        // Check if the child was found before trying to activate it.
        if (childTransform != null)
        {
            childTransform.gameObject.SetActive(true);
        }
        else
        {
            Debug.Log($"Child GameObject with name '{childToActivate}' not found on '{parentObject.name}'.");
        }
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
