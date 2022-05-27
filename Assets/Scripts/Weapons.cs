using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Weapon", fileName = "New Weapon")]

public class Weapons : ScriptableObject
{
    public string weaponName;
    public string weaponDescription;
    public Sprite weaponSprite;
    public float weaponDamage;
}