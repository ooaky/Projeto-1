using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EnemyData : ScriptableObject
{
    public int startlife = 3;
    public float force = 10;

    [Header("Color Setup")]
    public Color colorDamageable = Color.magenta;

}
