using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : BaseCollision
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            HandleCollisionEnter();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            HandleTriggerEnter();
        }
    }

    protected override void HandleCollisionEnter()
    {
        Debug.Log("Game Over");
    }

    protected override void HandleTriggerEnter()
    {
        HandleBulletCollision();
    }

    protected virtual void HandleBulletCollision()
    {
        Destroy(gameObject);
    }
}
