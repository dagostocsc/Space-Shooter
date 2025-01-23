using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Boundary2
{
    public float xMin, xMax, zMin, zMax;
}


public class PlayerMovement : MonoBehaviour
{
  
    public Boundary1 boundary1;
    public float speed;
    Rigidbody RB;
    
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float MoveX = Input.GetAxis("Horizontal");
        float MoveZ = Input.GetAxis("Vertical");

        RB.linearVelocity = new Vector3(MoveX * speed,RB.linearVelocity.y , MoveZ * speed);
        Vector3 viewp = RB.linearVelocity;
        viewp.x = Mathf.Clamp(viewp.x,boundary1.xMin,boundary1.xMax);
        viewp.z = Mathf.Clamp(viewp.x, boundary1.zMin, boundary1.zMax);
        RB.linearVelocity = viewp;
        /* transform.position = new Vector3(
              Mathf.Clamp(transform.position.x, boundary1.xMin, boundary1.xMax),
              0,
              Mathf.Clamp(transform.position.z, boundary1.zMin, boundary1.zMax)
              );*/
    }




}
