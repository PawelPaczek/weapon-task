using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WeaponView : MonoBehaviour
{
    [SerializeField] private Image _weaponIcon;
    [SerializeField] private TextMeshProUGUI _weaponName;

    private void Start()
    {
        _weaponIcon.enabled = true;
        _weaponName.enabled = true;
    }

    public void UpdateView(string name, Sprite icon)
    {
        _weaponName.text = name;
        _weaponIcon.sprite = icon;
    }
}