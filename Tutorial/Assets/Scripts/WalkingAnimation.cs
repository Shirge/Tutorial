using UnityEngine;

public class WalkingAnimation : MonoBehaviour
{
    private Animator animation;
    private float buffer = 0.02f;

    void Start()
    {
        animation = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            buffer = 0.02f;
            animation.SetTrigger("Walk");
            animation.ResetTrigger("Idle");
            animation.ResetTrigger("WalkR");
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            buffer = 0.02f;
            animation.SetTrigger("WalkR");
            animation.ResetTrigger("Idle");
            animation.ResetTrigger("Walk");
        }
        else
        {
            buffer -= Time.deltaTime;

            if (buffer > 0)
            {
                return;
            }
            animation.SetTrigger("Idle");
            animation.ResetTrigger("Walk");
            animation.ResetTrigger("WalkR");
        }
    }
}
