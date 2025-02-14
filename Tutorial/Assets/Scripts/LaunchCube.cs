using UnityEngine;

public class LaunchCube : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(0, 500, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
