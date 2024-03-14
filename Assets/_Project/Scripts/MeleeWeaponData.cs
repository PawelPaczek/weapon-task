using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Melee WeaponData", menuName = "Weapons/Melee WeaponData")]
public class MeleeWeaponData : WeaponData, IMeleeWeaponData
{
    [SerializeField] private int durability;
    public int Durability => durability;
}