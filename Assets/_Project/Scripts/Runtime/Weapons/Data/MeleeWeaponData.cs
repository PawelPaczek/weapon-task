using UnityEngine;

[CreateAssetMenu(fileName = "New Melee WeaponData", menuName = "Weapons/Melee WeaponData")]
public class MeleeWeaponData : WeaponData, IMeleeWeaponData
{
    [SerializeField] private int _durability;
    public int Durability => _durability;
}