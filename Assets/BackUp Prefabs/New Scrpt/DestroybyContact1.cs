using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroybyContact1 : MonoBehaviour
{
    [SerializeField] public GameObject explosion;
    [SerializeField] private GameObject playerExplosion;
    [SerializeField] private GameObject asteroidExplosion;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary1")
            return;

        Debug.Log($"{name} is colliding with {other.gameObject.name}");
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
        }

        if (other.gameObject.CompareTag("EnemyShip"))
        {
            Debug.Log("It damaged the Enemy Ship");
            Instantiate(explosion, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            ScoringSystem.Score += 10;
        }

        if (other.gameObject.CompareTag("Enemies"))
        {
            Debug.Log("It damaged the asteroid");
            Instantiate(asteroidExplosion, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            ScoringSystem.Score += 15;
        }

        if (other.gameObject.CompareTag("EnemyBullet"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }


}


//obserer pattern
//state machine
//cpmmand pattern