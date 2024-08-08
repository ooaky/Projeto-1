using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class EnemyBase : MonoBehaviour, IKillable, IDamageable<int>
{
    public EnemyData enemyData;


    private int _currentlife;

    private void Awake()
    {
        Init();
    }
    #region Code
    protected virtual void Init()
    {
        _currentlife = enemyData.startlife;
    }

    public virtual void Attack()
    {
        UnityEngine.Debug.Log("Attack : ");
    }

    public virtual void OnDamage() { }

    #endregion

    #region Interfaces
    public void kill()
    {
        Destroy(gameObject);
    }

    public void Damage(int f)
    {
        _currentlife -= f;
        transform.localScale *= 0.9f;

        OnDamage();

        if (_currentlife <= 0) kill();
    }
    #endregion


}

