using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : BaseShoot
{
    protected override void HandleFire()
    {
        if (Input.GetButton("Fire1") && (Time.time > _nextShotTime))
        {
            Fire();
            _nextShotTime = Time.time + _delayBetweenShots;
        }
    }
}
