using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroybyContact1 : MonoBehaviour
{
    [SerializeField] public GameObject explosion;
    [SerializeField] private GameObject playerExplosion;
    [SerializeField] private GameObject asteroidExplosion;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Boundary1")
            return;

        Debug.Log($"{name} is colliding with {collision.gameObject.name}");
        if (collision.collider.gameObject.CompareTag("Player"))
        {
            Instantiate(playerExplosion, collision.transform.position, collision.transform.rotation);
        }

        if (collision.collider.gameObject.CompareTag("EnemyShip"))
        {
            Debug.Log("it damaged the Enemy Ship");
            Instantiate(explosion, collision.transform.position, collision.transform.rotation);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            ScoringSystem.Score += 10;
        }

        if (collision.collider.gameObject.CompareTag("Enemies"))
        {
            Debug.Log("it damaged the asteroid");
            Instantiate(asteroidExplosion, collision.transform.position, collision.transform.rotation);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            ScoringSystem.Score += 15;
        }

        if (collision.collider.gameObject.CompareTag("EnemyBullet"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }

}


//obserer pattern
//state machine
//cpmmand pattern