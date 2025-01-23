using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Boundary1
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerController1 : MonoBehaviour
{
    public float speed;
    public Boundary1 boundary1;

    public GameObject shot;//instantiate THE FUNCTION
    public Transform shotSpawn;

    public float fireRate;//SHOOT THE BOLT
    private float nextFire;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        //vector means you have an x y and z
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        //Its releveant to the Rigid Body
        GetComponent<Rigidbody>().linearVelocity = movement * speed;

        GetComponent<Rigidbody>().position = new Vector3(
            Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundary1.xMin, boundary1.xMax),
            0,
            Mathf.Clamp(GetComponent<Rigidbody>().position.z, boundary1.zMin, boundary1.zMax)
            );
    }
}
