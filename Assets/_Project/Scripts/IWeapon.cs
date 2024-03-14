using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapon 
{
     string ItemName { get; }
     int Damage{ get; }
     string IconAddress{ get; }
    void Select();
    void Use();
}
