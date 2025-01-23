using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDir : MonoBehaviour
{
    Rigidbody RB;
    [SerializeField]
    int speed;

    
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        Destroy(gameObject, 5f);
        
    }

    // Update is called once per frame
    void Update()
    {

        RB.linearVelocity = new Vector3(RB.linearVelocity.x, RB.linearVelocity.y, 3*speed);

    }
}
