using UnityEngine;
using System.Collections;

public class EnemyTower_01 : MonoBehaviour {
    public Vector3 myRotation;
    public float timeMove;
    public float amplitude;
    public Quaternion Originalrotation;
    // Use this for initialization
    void Start()
    {
        myRotation = new Vector3 (transform.rotation.x, transform.rotation.y, transform.rotation.z);
        Originalrotation = transform.rotation;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        myRotation = new Vector3(
         transform.rotation.x,
         myRotation.y + amplitude * Mathf.Sin(Time.time * timeMove),
         transform.rotation.z
         );
        


        Quaternion rotation = Quaternion.Euler(myRotation); 
        transform.rotation = Originalrotation*rotation;


    }
}
