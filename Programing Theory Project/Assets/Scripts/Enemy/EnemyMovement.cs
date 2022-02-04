using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]private float _speed = 5;
    [SerializeField]private float _rotationSpeed = 50;
    private Transform _playerTransform;
    private Rigidbody _enemyRb;
    
    private void Awake()
    {
        _enemyRb = GetComponent<Rigidbody>();
        _playerTransform = GameObject.Find("Player").transform;
    }

    private void FixedUpdate()
    {
        TurnTowardsPlayer();
        MoveForward();
    }

    private void TurnTowardsPlayer()
    {
        Vector3 enemyPlayer = (_playerTransform.position - transform.position).normalized;
        Quaternion look = Quaternion.LookRotation(enemyPlayer);
        float step = _rotationSpeed * Time.deltaTime;
        Quaternion q = Quaternion.RotateTowards(transform.rotation, look, step); 
        _enemyRb.MoveRotation(q);
    }

    private void MoveForward()
    {
        _enemyRb.velocity = transform.forward * _speed;
    }
}
