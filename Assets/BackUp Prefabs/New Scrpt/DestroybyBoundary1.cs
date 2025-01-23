using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroybyBoundary1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerExit(Collider collision)
    {
        if(collision.gameObject.CompareTag("Enemies") || collision.gameObject.CompareTag("EnemyShip"))
        Destroy(collision.gameObject);
    }
}
