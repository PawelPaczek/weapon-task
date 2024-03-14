using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponsController : MonoBehaviour
{
   [SerializeField] private List<WeaponData> _weaponsData;
   [SerializeField] private int _currentWeaponIndex;
   [SerializeField] private WeaponView _weaponView;
   private PlayerInputActions _playerInputActions;
   
   private List<IWeapon> weapons;

   private void Awake()
   {
       _playerInputActions=new PlayerInputActions();
   }

   private void OnEnable()
   {
       _playerInputActions.Player.UseWeapon.Enable();
       _playerInputActions.Player.SelectNextWeapon.Enable();
       _playerInputActions.Player.UseWeapon.performed += UseWeapon;
       _playerInputActions.Player.SelectNextWeapon.performed += SelectNextWeapon;
   }

   private void Start()
    {
        weapons = CreatWeaponsFromData(_weaponsData);
        _currentWeaponIndex = 0;
        SelectWeapon();
    }
    
    private List<IWeapon> CreatWeaponsFromData(List<WeaponData> weaponsData)
    {
        List<IWeapon> newWeaponsList = new List<IWeapon>();
    
        foreach (WeaponData weaponData in weaponsData)
        {
            newWeaponsList.Add(weaponData switch
            {
                RangedWeaponData rangedWeaponData => new RangedWeapon(rangedWeaponData),
                MeleeWeaponData meleeWeaponData => new MeleeWeapon(meleeWeaponData),
                _ => throw new ArgumentException("Unknown weapon type!")
            });
        }
        return newWeaponsList;
    }
    
    private void UseWeapon(InputAction.CallbackContext callbackContext)
    {
        weapons[_currentWeaponIndex].Use();
    }

    private void SelectNextWeapon(InputAction.CallbackContext callbackContext)
    {
        _currentWeaponIndex = (_currentWeaponIndex + 1) % weapons.Count;
        SelectWeapon();
    }

    private async void SelectWeapon()
    {
        weapons[_currentWeaponIndex].Select();
        Sprite weaponIcon = await AddressablesExtensions.LoadSpriteAsyncFromPath(weapons[_currentWeaponIndex].IconAddress);
        _weaponView.UpdateView(weapons[_currentWeaponIndex].ItemName,weaponIcon);
    }

    private void OnDisable()
    {
        _playerInputActions.Player.UseWeapon.performed -= UseWeapon;
        _playerInputActions.Player.SelectNextWeapon.performed -= SelectNextWeapon;
    }
}
