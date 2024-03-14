using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeaponData
{
    string Name { get; }
    int Damage { get; }
    string IconAddress { get; }
}