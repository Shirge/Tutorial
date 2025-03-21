using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterAnimation : MonoBehaviour
{
    InputAction interact;
    Animator animator;

    private void Start()
    {
        interact = InputSystem.actions.FindAction("Interact");
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (interact.WasReleasedThisFrame())
        {
            animator.SetTrigger("OnClick");
        }
    }
}
