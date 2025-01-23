using UnityEngine;
using System.Collections;

public class EnemyMover : MonoBehaviour {

    public float speed;

    void Start()
    {
        GetComponent<Rigidbody>().linearVelocity = transform.forward * speed;
    }
}
