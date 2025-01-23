using UnityEngine;
using System.Collections;

public class EnemyShip_01 : MonoBehaviour
{
    public GameObject Bullet;
    //public GameObject Rocket;
    //public GameObject RocketBig;
    public GameObject Gun_01;
    public GameObject Gun_02;

    public Transform ShotSpawn01;
    public Transform ShotSpawn02;


    //public Transform ShotSpawnRocket01;
    //public Transform ShotSpawnRocket02;


    public float fireRate;
   // public float fireRateRocket;


    private float nextFire;
    //private float nextFireRocket;



    void FixedUpdate()
    {

        //                  --- Gun Fire
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(Bullet, ShotSpawn01.position, ShotSpawn01.rotation);
            Instantiate(Gun_01, ShotSpawn01.position, ShotSpawn01.rotation, transform.parent = gameObject.transform);

            Instantiate(Bullet, ShotSpawn02.position, ShotSpawn02.rotation);
            Instantiate(Gun_01, ShotSpawn02.position, ShotSpawn02.rotation, transform.parent = gameObject.transform);

        }

    }
}
