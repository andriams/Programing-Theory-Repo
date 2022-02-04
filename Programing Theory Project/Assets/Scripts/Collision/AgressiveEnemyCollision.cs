using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgressiveEnemyCollision : EnemyCollision
{
    [SerializeField] protected int _nbCollisionsBeforeDestroy = 3;

    protected override void HandleBulletCollision()
    {
        _nbCollisionsBeforeDestroy--;
        if (_nbCollisionsBeforeDestroy == 0)
        {
            base.HandleBulletCollision();
        }
    }
}
