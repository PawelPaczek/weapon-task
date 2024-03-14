using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WeaponView : MonoBehaviour
{
    [SerializeField] private Image weaponIcon;
    [SerializeField] private TextMeshProUGUI weaponName;

    private void Start()
    {
        weaponIcon.enabled = true;
        weaponName.enabled = true;
    }

    public void UpdateView(string name, Sprite icon)
    {
        weaponName.text = name;
        weaponIcon.sprite = icon;
    }
}