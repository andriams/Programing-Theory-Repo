using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]protected float _speed = 5;
    [SerializeField]protected float _rotationSpeed = 50;
    protected Transform _playerTransform;
    protected Rigidbody _enemyRb;
    private GameManager _gameManager;

    protected void Awake()
    {
        _enemyRb = GetComponent<Rigidbody>();
        _playerTransform = GameObject.Find("Player").transform;
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    protected void FixedUpdate()
    {
        if (_gameManager.IsGameOver)
        {
            _enemyRb.velocity = Vector3.zero;
            return;
        }

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

    protected virtual void MoveForward()
    {
        _enemyRb.velocity = transform.forward * _speed;
    }
}
