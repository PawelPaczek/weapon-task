using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : ScriptableObject, IWeapon
{
    [SerializeField] private string name;
    [SerializeField] private int damage;
    [SerializeField] private Sprite icon;

    public string Name => name;
    public int Damage => damage;
    public Sprite Icon => icon;

    public virtual void SelectWeapon()
    {
    }

    public virtual void UseWeapon()
    {
    }
}