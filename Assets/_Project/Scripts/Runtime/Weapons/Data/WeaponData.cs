using UnityEngine;

public class WeaponData : ScriptableObject, IWeaponData
{
    [SerializeField] private string _name;
    [SerializeField] private int _damage;
    [SerializeField] private string _iconAddress;

    public string Name => _name;
    public int Damage => _damage;
    public string IconAddress => _iconAddress;
}