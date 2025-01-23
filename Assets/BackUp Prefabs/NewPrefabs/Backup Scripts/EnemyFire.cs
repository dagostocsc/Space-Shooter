using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    [SerializeField]
    GameObject FirePos;
    [SerializeField]
    GameObject EnemyBullet;
    Transform TR;
    private void Awake()
    {
        TR = GetComponent<Transform>();
        TR.Rotate(0, 180, 0);
    }
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(BulletTime());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator BulletTime()
    {
        while (true)
        {
            Instantiate(EnemyBullet, FirePos.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
        
    }
}
