using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseShoot : MonoBehaviour
{
    [SerializeField] protected GameObject _bullet;
    [SerializeField] protected Transform _spawnPoint;
    [SerializeField] protected float _delayBetweenShots = 0.5f;
    protected float _nextShotTime;

    // Update is called once per frame
    void Update()
    {
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
