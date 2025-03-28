using UnityEngine;

public class MoveNoTurn : MonoBehaviour
{
    [SerializeField] private float speed = 50f;

    private void Update()
    {
        Vector3 positionUpdate = transform.position + Input.GetAxis("Vertical") * transform.forward * speed * Time.deltaTime + Input.GetAxis("Horizontal") * transform.right * speed * Time.deltaTime;
        transform.position = positionUpdate;
    }
}