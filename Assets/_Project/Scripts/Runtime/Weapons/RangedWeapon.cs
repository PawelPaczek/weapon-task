using UnityEngine;

public class RangedWeapon : IWeapon
{
    private readonly RangedWeaponData _data;
    public string ItemName => _data.Name;
    public int Damage => _data.Damage;
    public string IconAddress => _data.IconAddress;

    private int _currentAmmoCount;

    public RangedWeapon(RangedWeaponData data)
    {
        _data = data;
        _currentAmmoCount = data.AmmoCount;
    }

    public void Select()
    {
        Debug.Log($"Using ranged weapon: {ItemName}");
    }

    public void Use()
    {
        Debug.Log($"Using ranged weapon: {ItemName}");
        if (_currentAmmoCount > 0)
        {
            UpdateAmmoCount(-1);
            Debug.Log($"Ammo left: {_currentAmmoCount}");
        }
        else
        {
            Debug.Log($"Ammo left: {_currentAmmoCount}, reload your weapon");
        }
    }

    private void UpdateAmmoCount(int amount)
    {
        _currentAmmoCount += amount;
    }
}