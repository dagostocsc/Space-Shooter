using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject Enemy_Fighter_01;

    [SerializeField]
    private float _minimumSpawnTime;

    [SerializeField]
    private float _maximumSpawnTime;

    private float _timeUntilSpawn;

    private void Awake()
    {
        SetTimeUntilSpawn();
    }

    private void Update()
    {
        _timeUntilSpawn -= Time.deltaTime; // Decrease time until spawn each frame

        if (_timeUntilSpawn <= 0)
        {
            Instantiate(Enemy_Fighter_01, transform.position, Quaternion.identity); 
            SetTimeUntilSpawn();
        }
    }

    private void SetTimeUntilSpawn()
    {
        _timeUntilSpawn = Random.Range(_minimumSpawnTime, _maximumSpawnTime);
    }
}
