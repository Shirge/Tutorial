using UnityEngine;

public class GetPickup : MonoBehaviour
{
    private Renderer render;
    private AudioSource source;
    private ParticleSystem particleSystem;
    private KeepScore scoreScript;


    private void Start()
    {
        render = GetComponent<Renderer>();
        source = GetComponent<AudioSource>();
        particleSystem = GetComponent<ParticleSystem>();
        particleSystem.Stop();
        scoreScript = Object.FindFirstObjectByType<KeepScore>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            render.enabled = false;
            scoreScript.AddScore(1);
            source.Play();
            particleSystem.Play();
            GameObject.Destroy(gameObject, 0.5f);
        }
    }
}
