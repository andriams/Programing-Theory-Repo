using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _spawnPoint;
    private float _delayBetweenShots = 0.5f;
    private float _nextShotTime;

    private void Awake()
    {
        _nextShotTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && (Time.time > _nextShotTime))
        {
            Fire();
            _nextShotTime = Time.time + _delayBetweenShots;
        }
    }

    private void Fire()
    {
        GameObject bullet = Instantiate(_bullet, _spawnPoint.position, transform.rotation);
        bullet.GetComponent<Bullet>().Shoot(10);
        Destroy(bullet, 2);
    }
}
