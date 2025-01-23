using UnityEngine;
using UnityEngine.SceneManagement;

public class Phealth : MonoBehaviour
{
    [SerializeField] private GameObject GameOvermenu;
    public PlayerHealth PH;
    private int MaxplayerHealth = 1000;
    public static int currentHealth;
    private int damage1 = 200;

    void Start()
    {
        currentHealth = MaxplayerHealth;
        PH.SetMaxHealth(MaxplayerHealth);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemies") || collision.gameObject.CompareTag("EnemyShip"))
        {
            currentHealth -= damage1;
            PH.Health(currentHealth);
            Destroy(collision.gameObject);
            if (currentHealth <= 0)
            {
                Destroy(gameObject);
                GameOvermenu.SetActive(true); // Trigger the game over sequence
            }
        }
    }

    
}
