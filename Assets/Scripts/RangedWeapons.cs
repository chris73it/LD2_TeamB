using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/RangedWeapons")]
public class RangedWeapons : ScriptableObject
{
    public int MagCurrent;
    public int MagSize;

    public int bulletCount;
    public int bulletSpread;
    public float bulletSpeed;
    public bool speedFallOff;

    public Sprite projectileSprite;

    public float useRate;
    public float reloadTime;
    public int damage;

    public void setClip(int what)
    {
        MagCurrent = what;
    }
}
