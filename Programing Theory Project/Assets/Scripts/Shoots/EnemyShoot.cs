using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : BaseShoot
{
    protected override void HandleFire()
    {
        if (Time.time > _nextShotTime)
        {
            Fire();
            _nextShotTime = Time.time + _delayBetweenShots;
        }
    }
}
