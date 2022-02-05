using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseShoot : MonoBehaviour
{
    [SerializeField] protected GameObject _bullet;
    [SerializeField] protected Transform _spawnPoint;
    [SerializeField] protected float _delayBetweenShots = 0.5f;
    private GameManager _gameManager;
    protected float _nextShotTime;

    private void Awake()
    {
        _nextShotTime = Time.time;
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        if (_gameManager.IsGameOver)
            return;

        HandleFire();
    }

    protected abstract void HandleFire();
    protected void Fire()
    {
        GameObject bullet = Instantiate(_bullet, _spawnPoint.position, transform.rotation);
        bullet.GetComponent<Bullet>().Shoot(10);
        Destroy(bullet, 2);
    }
    
    
}
