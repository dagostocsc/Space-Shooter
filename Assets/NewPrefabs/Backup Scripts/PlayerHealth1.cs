using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth1 : MonoBehaviour
{
    [SerializeField] GameObject GameOverTab;
    int playerMaxHealth = 5;
    int CurrentHealth;
    public Healthbar healthbar;
    [SerializeField]
    GameObject PlayerExplosionEffect;
    private void Start()
    {
        CurrentHealth = playerMaxHealth;
        healthbar.MaxHealth(playerMaxHealth);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Enemies"))
        {
            CurrentHealth -= 2;
            healthbar.SetHealth(CurrentHealth);
            Destroy(collision.gameObject);
            if (CurrentHealth <= 0)
            {
                Instantiate(PlayerExplosionEffect, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }

        if (collision.collider.gameObject.CompareTag("EnemyBullet"))
        {
            CurrentHealth -= 1;
            healthbar.SetHealth(CurrentHealth);
            Destroy(collision.gameObject);
            if (CurrentHealth <= 0)
            {
                Instantiate(PlayerExplosionEffect, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
                
        }
        
    }
}
