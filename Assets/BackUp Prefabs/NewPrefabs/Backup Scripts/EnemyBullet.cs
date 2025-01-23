using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    Rigidbody RB;
    [SerializeField]
    int BulletSpeed=4;
    
    
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        RB.AddForce(0, 0, -2f * BulletSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        

        if (collision.collider.gameObject.CompareTag("Enemies") || collision.collider.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
           
    }
}
