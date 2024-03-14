using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeWeapon : IWeapon
{
    public string itemName;
    public int damage;
    public string iconAddress;
    public int ammoCount;

    public string ItemName => itemName;
    public int Damage => damage;
    public string IconAddress => iconAddress;

    public void Select()
    {
        Debug.Log($"Using ranged weapon: {itemName}");
    }

    public void Use()
    {
        if (ammoCount > 0)
        {
            Debug.Log($"Using ranged weapon: {itemName}");
            UpdateAmmoCount(-1);
            Debug.Log($"Ammo left: {ammoCount}");
        }
        else
        {
            Debug.Log($"Ammo left: {ammoCount}, reload your weapon");
        }
    }

    private void UpdateAmmoCount(int amount)
    {
        ammoCount += amount;
    }
}