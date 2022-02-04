using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float _speed = 0;
    private Rigidbody _bulletRb;

    private void Awake()
    {
        _bulletRb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 step = transform.forward * _speed * Time.fixedDeltaTime;
        _bulletRb.MovePosition(transform.position + step);
    }

    public void Shoot(float speed)
    {
        _speed = speed;
    }
}
