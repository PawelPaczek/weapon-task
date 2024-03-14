using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ranged Weapon", menuName = "Weapons/Ranged Weapon")]
public class RangedWeapon : Weapon
{
    [SerializeField] private int ammoCount;
    
    public override void SelectWeapon()
    {
        base.SelectWeapon();
        Debug.Log("Select melee weapon: " + Name);
    }
    
    public override void UseWeapon()
    {
        base.UseWeapon();
        Debug.Log("Using ranged weapon: " + Name);
    }

}
