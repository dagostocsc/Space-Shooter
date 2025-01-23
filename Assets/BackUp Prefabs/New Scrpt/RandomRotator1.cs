using UnityEngine;
using System.Collections;

public class RandomRotator1 : MonoBehaviour
{
    public float tumble;

    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
    }
}