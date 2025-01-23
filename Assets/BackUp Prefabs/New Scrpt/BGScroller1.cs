using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;

public class BGScroller1 : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip shadows;
    public float scrollSpeed; // Speed at which the background scrolls.
    public float tileSizeZ; // Size of the background tile on the Z-axis.

    private Vector3 startPosition; // Initial position of the background.

    void Start()
    {
        // Save the initial position of the object this script is attached to.
        startPosition = transform.position;
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    void Update()
    {
        // Calculate the new position using Mathf.Repeat to loop the offset.
        float offset = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
        transform.position = startPosition + Vector3.forward * offset;
        audioSource.clip = shadows;
        audioSource.Play();

        // If you'd like to dynamically reposition or loop multiple tiles,
        // this calculation ensures the background wraps seamlessly.
    }
    public void setVolune()
    {

    }
}



