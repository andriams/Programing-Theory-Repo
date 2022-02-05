using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : BaseCollision
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            HandleTriggerEnter();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            HandleCollisionEnter();
        }
    }

    protected override void HandleTriggerEnter()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().GameOver();
        Destroy(gameObject);
    }

    protected override void HandleCollisionEnter()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().GameOver();
        Destroy(gameObject);
    }
}
