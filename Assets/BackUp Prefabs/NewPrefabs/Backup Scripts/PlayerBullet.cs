using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField]
    GameObject PBullet;
    [SerializeField]
    GameObject FirePos;
    float FireRate=0.7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FireRate -= Time.deltaTime;
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (FireRate <= 0)
            {
                Instantiate(PBullet, FirePos.transform.position, Quaternion.identity);
                FireRate = 0.7f;
            }
        }

            

        
    }
}
