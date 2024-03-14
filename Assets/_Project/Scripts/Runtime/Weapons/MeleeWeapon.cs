using UnityEngine;

public class MeleeWeapon : IWeapon
{
    private readonly MeleeWeaponData _data;

    public string ItemName => _data.Name;
    public int Damage => _data.Damage;
    public string IconAddress => _data.IconAddress;

    private int _durability;

    public MeleeWeapon(MeleeWeaponData data)
    {
        _data = data;
        _durability = data.Durability;
    }

    public void Select()
    {
        Debug.Log($"Using melee weapon: {ItemName}");
    }

    public void Use()
    {
        if (_durability > 0)
        {
            Debug.Log($"Using melee weapon: {ItemName}");
            UpdateDurability(-1);
            Debug.Log($"Durability left: {_durability}");
        }
        else
        {
            Debug.Log($"Durability left: {_durability}, fix your weapon");
        }
    }

    public void UpdateDurability(int amount)
    {
        _durability += amount;
    }
}