using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController1 : MonoBehaviour
{
    [SerializeField] private GameObject GameOvermenu;
    public GameObject hazard1;
    public GameObject hazard2;
    public Vector3 spawnValue;
    public float spawnWait = 2f;
    private bool isGameOver = false;

    void Start()
    {
        StartCoroutine(SpawnMeteors());
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnMeteors()
    {
        while (!isGameOver)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-4, 4), 0, 8);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(hazard1, spawnPosition, spawnRotation);

            yield return new WaitForSeconds(1f);
        }

    }

    IEnumerator SpawnEnemies()
    {
        while (!isGameOver)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-4, 4), 0, 8);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(hazard2 , spawnPosition, spawnRotation);

            yield return new WaitForSeconds(5f);
        }
    }

    public void TriggerGameOver()
    {
        isGameOver = true;
        GameOvermenu.SetActive(true);
    }
}

//enemies
//player position
