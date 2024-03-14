using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponData : ScriptableObject, IWeaponData
{
    [SerializeField] private string name;
    [SerializeField] private int damage;
    [SerializeField] private string iconAddress;

    public string Name => name;
    public int Damage => damage;
    public string IconAddress => iconAddress;
}