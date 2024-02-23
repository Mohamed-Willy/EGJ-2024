using UnityEngine;
enum state
{
    idle,
    run,
    walk,
    eat,
    sit,
    sleep,
    attack
}
public class BearState : MonoBehaviour
{
    Animator animator;
    [SerializeField] state AnimationState;
    private void OnEnable()
    {
        animator = GetComponent<Animator>();
        if (AnimationState == state.idle) animator.SetBool("Idle", true);
        if (AnimationState == state.run) animator.SetBool("Run Forward", true);
        if (AnimationState == state.walk) animator.SetBool("WalkForward", true);
        if (AnimationState == state.eat) animator.SetBool("Eat", true);
        if (AnimationState == state.sit) animator.SetBool("Sit", true);
        if (AnimationState == state.sleep) animator.SetBool("Sleep", true);
        if (AnimationState == state.attack) animator.SetBool("Attack", true);
    }
}
