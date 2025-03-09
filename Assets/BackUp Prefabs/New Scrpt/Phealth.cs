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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemies") || other.gameObject.CompareTag("EnemyShip"))
        {
            currentHealth -= damage1;
            PH.Health(currentHealth);
            Destroy(other.gameObject);
            if (currentHealth <= 0)
            {
                Destroy(gameObject);
                GameOvermenu.SetActive(true); // Trigger the game over sequence
            }
        }
    }

    
}
