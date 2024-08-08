using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyScale : EnemyBase
{
    [Header("Enemy Scale")]
    public float scale = 1.5f;
    public float duration = 1.5f;
    public float durationFor = 100f;

    [Space()]
    public MeshRenderer meshRenderer;

    private bool _attacking = false;
    private Coroutine _currentCoroutine;


    public override void Attack()
    {
        base.Attack();

        if (!_attacking)
        {
            _attacking = true;
            //transform.localScale = transform.localScale * scale;
            transform.localScale *= scale;
            //Invoke("ResetScale", duration);
            //Invoke(nameof(ResetScale), duration);
            //StartCoroutine(DelayCall());
            //StartCoroutine(ChangeColorCoroutine());
            //ChangeColor();
        }


    }

    public void ResetScale()
    {
        transform.localScale = Vector3.one;
        _attacking = false;
    }


    IEnumerator DelayCall()
    {
        yield return new WaitForSeconds(duration);

        transform.localScale *= scale;

        yield return new WaitForSeconds(duration);

        transform.localScale = Vector3.one;
        _attacking = false;
    }


    private void ChangeColor()
    {
        for (float i = 1f; i >= 0; i -= .001f)
        {
            meshRenderer.material.SetColor(("_Color"), Color.Lerp(Color.white, Color.red, 1 - i));
        }
    }

    IEnumerator ChangeColorCoroutine()
    {
        for (float i = 1f; i >= 0; i -= .02f)
        {
            meshRenderer.material.SetColor(("_Color"), Color.Lerp(Color.white, enemyData.colorDamageable, 1 - i));
            yield return new WaitForEndOfFrame();
        }

        _currentCoroutine = null;
    }

    #region Overrides
    public override void OnDamage()
    {
        base.OnDamage();
        if (_currentCoroutine == null)
        {
            _currentCoroutine = StartCoroutine(ChangeColorCoroutine());
        }

    }
    #endregion
}
