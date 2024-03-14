using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsController : MonoBehaviour
{
   [SerializeField] private List<WeaponData> weaponsData;
   [SerializeField] private List<IWeapon> weapons;
   [SerializeField] private int currentWeaponIndex;
   [SerializeField] private WeaponView weaponView;
   [SerializeField] private AddressablesLoader addressablesLoader;
   
    private void Start()
    {
        weapons = CreatWeaponsFromData(weaponsData);
        currentWeaponIndex = 0;
        SelectWeapon();
    }
    
    private List<IWeapon> CreatWeaponsFromData(List<WeaponData> weaponsData)
    {
        List<IWeapon> newWeaponsList = new List<IWeapon>();
    
        foreach (WeaponData weaponData in weaponsData)
        {
            newWeaponsList.Add(weaponData switch
            {
                RangedWeaponData rangedWeapon => new RangeWeapon()
                {
                    itemName = rangedWeapon.Name,
                    damage = rangedWeapon.Damage,
                    iconAddress = rangedWeapon.IconAddress,
                    ammoCount = rangedWeapon.AmmoCount
                },
                MeleeWeaponData meleeWeapon => new MeleeWeapon()
                {
                    itemName = meleeWeapon.Name,
                    damage = meleeWeapon.Damage,
                    iconAddress = meleeWeapon.IconAddress,
                    durability = meleeWeapon.Durability
                },
                _ => throw new ArgumentException("Unknown weapon type!")
            });
        }
    
        return newWeaponsList;
    }
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            UseWeapon();
        }

        if (Input.GetMouseButtonDown(1))
        {
            SelectNextWeapon();
        }
    }

    private void UseWeapon()
    {
        weapons[currentWeaponIndex].Use();
    }

    private void SelectNextWeapon()
    {
        currentWeaponIndex = (currentWeaponIndex + 1) % weapons.Count;
        SelectWeapon();
    }

    private async void SelectWeapon()
    {
        weapons[currentWeaponIndex].Select();
        Sprite weaponIcon = await addressablesLoader.GetIconAssetAsync(weapons[currentWeaponIndex].IconAddress);
        weaponView.UpdateView(weapons[currentWeaponIndex].ItemName,weaponIcon);
    }
}
