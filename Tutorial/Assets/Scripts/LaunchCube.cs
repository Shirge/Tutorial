using UnityEngine;
using UnityEngine.InputSystem;

public class LaunchCube : MonoBehaviour
{
    InputAction interact;

    private void Start()
    {
        interact = InputSystem.actions.FindAction("Interact");
    }

    private void Update()
    {
        if (interact.WasReleasedThisFrame())
        {
            gameObject.GetComponent<Rigidbody>().AddForce(0, 5, 0, ForceMode.Impulse);
        }
    }
}
