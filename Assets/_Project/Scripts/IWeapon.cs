using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapon
{
    string Name { get; }
    int Damage { get; }
    Sprite Icon { get; }

    void SelectWeapon();
    void UseWeapon();
}