using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            HandleBulletCollision();
        }
    }

    private void HandleBulletCollision()
    {
        Debug.Log("Shoot Game Over!!");
    }
}
