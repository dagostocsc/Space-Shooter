using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn1 : MonoBehaviour
{
    public List<GameObject> SpawnCharacters;
    Vector3 SpawnLocation;
    // Start is called before the first frame update
    void Start()
    {
        //SpawnCharacters = new List<GameObject>(Resources.LoadAll<GameObject>("Enemies"));
        StartCoroutine(spawnWait());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnWait()
    {
        int index = 0;
        while (true)
        {
            SpawnLocation = new Vector3(Random.Range(-2.5f, 2.5f), 0, 10);
            
              Instantiate(SpawnCharacters[index % SpawnCharacters.Count], SpawnLocation, Quaternion.identity);
              index++;
              yield return new WaitForSeconds(1f);
            
            
        }
        
    }

}
