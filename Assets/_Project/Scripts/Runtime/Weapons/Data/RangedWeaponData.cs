using UnityEngine;

[CreateAssetMenu(fileName = "New Ranged WeaponData", menuName = "Weapons/Ranged WeaponData")]
public class RangedWeaponData : WeaponData, IRangedWeaponData
{
    [SerializeField] private int _ammoCount;
    public int AmmoCount => _ammoCount;
}