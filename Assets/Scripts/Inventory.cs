using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;

    public Weapons[] weapons;
    public Text[] weaponsNameText;
    public Text[] weaponsDescriptionText;
    public Image[] weaponsSprites;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void AddWeapon(Weapons item)
    {
        for(int i = 0; i < weapons.Length; i++)
        {
            if(weapons[i] == null)
            {
                weapons[i] = item;
                weaponsNameText[i].text = item.weaponName;
                weaponsDescriptionText[i].text = item.weaponDescription + " Damage = " + item.weaponDamage;
                weaponsSprites[i].sprite = item.weaponSprite;

                return;
            }
        }
    }
}