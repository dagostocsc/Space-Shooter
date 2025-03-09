using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroybyContact1 : MonoBehaviour
{
    [SerializeField] private GameObject asteroidExplosion; // Asteroid explosion effect
    [SerializeField] private GameObject playerExplosion; // Player explosion effect
    [SerializeField] private GameObject enemyExplosion; // Enemy ship explosion effect

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{name} collided with {other.gameObject.name}");

        if (other.CompareTag("Boundary1"))
            return;

        // Handle player collision
        if (other.CompareTag("Player"))
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject); // Destroy player
        }

        // Handle asteroid collision
        if (other.CompareTag("Enemies"))
        {
            Instantiate(asteroidExplosion, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject); // Destroy asteroid
            Destroy(gameObject); // Destroy bolt
        }

        // Handle enemy ship collision
        if (other.CompareTag("EnemyShip"))
        {
            Instantiate(enemyExplosion, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject); // Destroy enemy ship
            Destroy(gameObject); // Destroy bolt
        }
    }
}
