using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeapon : IWeapon
{
    public string itemName;
    public int damage;
    public string iconAddress;
    public int durability;

    public string ItemName => itemName;
    public int Damage => damage;
    public string IconAddress => iconAddress;

    public void Select()
    {
        Debug.Log($"Using melee weapon: {itemName}");
    }

    public void Use()
    {
        if (durability > 0)
        {
            Debug.Log($"Using melee weapon: {itemName}");
            UpdateDurability(-1);
            Debug.Log($"Durability left: {durability}");
        }
        else
        {
            Debug.Log($"Durability left: {durability}, fix your weapon");
        }
    }

    public void UpdateDurability(int amount)
    {
        durability += amount;
    }
}
