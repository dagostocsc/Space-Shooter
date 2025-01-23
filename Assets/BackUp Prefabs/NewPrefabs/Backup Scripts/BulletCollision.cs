using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Enemies"))
        {
            ScoreSystem.score += 1;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
