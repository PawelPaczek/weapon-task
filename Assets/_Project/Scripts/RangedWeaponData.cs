using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ranged WeaponData", menuName = "Weapons/Ranged WeaponData")]
public class RangedWeaponData : WeaponData, IRangedWeaponData
{
    [SerializeField] private int ammoCount;
    public int AmmoCount => ammoCount;
}