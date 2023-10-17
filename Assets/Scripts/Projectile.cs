using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody2D rigidbody2d;

    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    public void Launch(Vector2 direction, float force)
    {
        rigidbody2d.AddForce(direction * force);
    }

    void Update()
    {
        if (transform.position.magnitude > 1000.0f)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        EnemyController e = other.collider.GetComponent<EnemyController>();
        if (e != null)
        {
            e.Fix();
        }

        Destroy(gameObject);

        ZombieController z = other.collider.GetComponent<ZombieController>();
        if (z != null)
        {
            z.Dead();
        }

        ChestController c = other.collider.GetComponent<ChestController>();
        if (c != null)
        {
            other.gameObject.SendMessage("ChestDamaged", 1, SendMessageOptions.DontRequireReceiver);
            other.gameObject.SendMessage("TakenDamage", SendMessageOptions.DontRequireReceiver);
        }
    }
}