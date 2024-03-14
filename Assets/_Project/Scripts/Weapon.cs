using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : ScriptableObject, IWeapon
{
    [SerializeField] private string name;
    [SerializeField] private int damage;
    [SerializeField] private string iconAddress;

    public string Name => name;
    public int Damage => damage;
    public string IconAddress => iconAddress;

    public virtual void SelectWeapon()
    {
        
    }

    public virtual void UseWeapon()
    {
    }
}