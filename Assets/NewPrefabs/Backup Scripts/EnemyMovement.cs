using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody RB;

    private void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        RB.linearVelocity = new Vector3(0, 0, -2);
    }
}
