using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapon
{
    string Name { get; }
    int Damage { get; }
    string IconAddress { get; }

    void SelectWeapon();
    void UseWeapon();
}