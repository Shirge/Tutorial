using UnityEngine;

public class TrackPlayer : MonoBehaviour
{
    public Transform player;
    private Quaternion rotation;
    void Update()
    {
        Vector3 targetDirection = player.position - transform.position;
        rotation = Quaternion.LookRotation(targetDirection, Vector3.up);
        transform.rotation = rotation;
    }
}
