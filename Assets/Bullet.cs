using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float bulletSpeed = 15f;
    public Rigidbody2D rigidbodyObj;

    // Start is called before the first frame update
    void Start()
    {
        // allows our bullet to be created and move it in the right direction 
        rigidbodyObj.velocity = transform.right * bulletSpeed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        enemyDamage enemy = collision.GetComponent<enemyDamage>();
        if (enemy != null)
        {
            enemy.TakeDamage(40);
        }
        Destroy(gameObject);
    }
}
