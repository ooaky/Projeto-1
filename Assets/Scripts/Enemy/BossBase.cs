using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBase : MonoBehaviour, IKillable, IDamageable<int>
{
    public int life;
    [SerializeField] private float force;

    private int _currentlife;

    private void Awake()
    {
        Init();
    }
    #region Code
    protected virtual void Init()
    {
        _currentlife = life;
    }

    public virtual void Attack()
    {
        UnityEngine.Debug.Log("Attack : " + force);
    }
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

        if (_currentlife <= 0) kill();
    }
    #endregion


}
