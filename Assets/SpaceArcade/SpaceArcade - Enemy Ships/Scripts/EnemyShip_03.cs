using UnityEngine;
using System.Collections;

public class EnemyShip_03: MonoBehaviour
{
    public GameObject Bullet;
    public GameObject BulletBig;
    public GameObject Rocket;
    public GameObject Torpedo;
    public GameObject TorpedoBig;
    public GameObject EF_Enemy_Gun_Light_01;

    public Transform ShotSpawn01;
    public Transform ShotSpawn02;
    public Transform ShotSpawn03;
    public Transform ShotSpawn04;



    public Transform ShotSpawnRocket01;
    public Transform ShotSpawnRocket02;
    public Transform ShotSpawnTorpedo01;
    public Transform ShotSpawnTorpedo02;
    public Transform ShotSpawnTorpedoBig01;
    public Transform ShotSpawnTorpedoBig02;



    public float fireRate;
    public int fireCount;
    public float fireCountTime;

    public float fireRateBigBullets;
    public float fireRateRocket;
    public float fireRateTorpedo;
    public float fireRateTorpedoBig;


    private float nextFire;

    private int shoots;
    private float nextFireBig;
    private float nextFireRocket;
    private float nextFireTorpedo;
    private float nextFireTorpedoBig;


    private void Start()
    {
        shoots = fireCount;
    }
    void FixedUpdate()
    {

        // random fire
        int random = Random.Range(0,100);

        //                  --- Gun Fire
        if (shoots <= 1 & Time.time > nextFire)
        {
            nextFire = Time.time + fireCountTime;
            shoots = fireCount;
        }
        if (Time.time > nextFire & shoots > 1)
        {
            shoots -= 1;
            Debug.Log(random);

            nextFire = Time.time + fireRate;

            Instantiate(Bullet, ShotSpawn01.position, ShotSpawn01.rotation);
            Instantiate(EF_Enemy_Gun_Light_01, ShotSpawn01.position, ShotSpawn01.rotation, transform.parent = gameObject.transform);
            Instantiate(Bullet, ShotSpawn02.position, ShotSpawn02.rotation);
            Instantiate(EF_Enemy_Gun_Light_01, ShotSpawn02.position, ShotSpawn02.rotation, transform.parent = gameObject.transform);

        }


        //                  --- Gun Fire Big
        if (Time.time > nextFireBig)
        {
            nextFireBig = Time.time + fireRateBigBullets;

            Instantiate(BulletBig, ShotSpawn03.position, ShotSpawn03.rotation);
            Instantiate(EF_Enemy_Gun_Light_01, ShotSpawn03.position, ShotSpawn03.rotation, transform.parent = gameObject.transform);
            Instantiate(BulletBig, ShotSpawn04.position, ShotSpawn04.rotation);
            Instantiate(EF_Enemy_Gun_Light_01, ShotSpawn04.position, ShotSpawn04.rotation, transform.parent = gameObject.transform);


        }

        //                  --- Rocket Fire
        if (Time.time > nextFireRocket)
        {
            nextFireRocket = Time.time + fireRateRocket;
            Instantiate(Rocket, ShotSpawnRocket01.position, ShotSpawnRocket01.rotation);
            Instantiate(EF_Enemy_Gun_Light_01, ShotSpawnRocket01.position, ShotSpawnRocket01.rotation, transform.parent = gameObject.transform);
            Instantiate(Rocket, ShotSpawnRocket02.position, ShotSpawnRocket02.rotation);
            Instantiate(EF_Enemy_Gun_Light_01, ShotSpawnRocket02.position, ShotSpawnRocket02.rotation, transform.parent = gameObject.transform);

        }

        //                  --- Torpedo Fire
        if (Time.time > nextFireTorpedo)
        {
            nextFireTorpedo = Time.time + fireRateTorpedo;
            Instantiate(Torpedo, ShotSpawnTorpedo01.position, ShotSpawnTorpedo01.rotation);
            Instantiate(Torpedo, ShotSpawnTorpedo02.position, ShotSpawnTorpedo02.rotation);

        }


        //                  --- Torpedo BIG Fire
        if (Time.time > nextFireTorpedoBig)
        {
            nextFireTorpedoBig = Time.time + fireRateTorpedoBig;
            Instantiate(TorpedoBig, ShotSpawnTorpedoBig01.position, ShotSpawnTorpedoBig01.rotation);
            Instantiate(TorpedoBig, ShotSpawnTorpedoBig02.position, ShotSpawnTorpedoBig02.rotation);

        }


    }
}
