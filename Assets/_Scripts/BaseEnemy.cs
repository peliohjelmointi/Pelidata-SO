using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemy// : MonoBehaviour
{
    public virtual void Attack()
    {
        Debug.Log("Default Attack");
    }
}
