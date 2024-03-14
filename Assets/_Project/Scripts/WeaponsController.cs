using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsController : MonoBehaviour
{
   [SerializeField] private List<Weapon> weapons;
   [SerializeField] private int currentWeaponIndex;

    private void Start()
    {
        currentWeaponIndex = 0;
        SelectWeapon();
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
        weapons[currentWeaponIndex].UseWeapon();
    }

    private void SelectNextWeapon()
    {
        currentWeaponIndex = (currentWeaponIndex + 1) % weapons.Count;
        SelectWeapon();
    }

    private void SelectWeapon()
    {
        weapons[currentWeaponIndex].SelectWeapon();
        // Aktualizacja UI z nazwą i ikoną
    }
}
