using UnityEngine;

public class EnemyBulletCollision : MonoBehaviour
{
    [SerializeField]
    GameObject playerExplosion;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Player"))
        {
            Instantiate(playerExplosion, collision.transform.position, collision.transform.rotation);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        /*if( collision.collider.gameObject.CompareTag("EnemyShip") || collision.collider.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }*/
    }
}
