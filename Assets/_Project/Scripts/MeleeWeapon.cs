using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Melee Weapon", menuName = "Weapons/Melee Weapon")]
public class MeleeWeapon : Weapon
{
    public override void SelectWeapon()
    {
        base.SelectWeapon();
        Debug.Log("Select melee weapon: " + Name);
    }
    
    public override void UseWeapon()
    {
        base.UseWeapon();
        Debug.Log("Using melee weapon: " + Name);
    }
}