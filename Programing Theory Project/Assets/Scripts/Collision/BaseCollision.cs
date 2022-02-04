using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCollision : MonoBehaviour
{
    protected abstract void HandleTriggerEnter();
    protected abstract void HandleCollisionEnter();
}
