
using System;
using UnityEngine;
[CreateAssetMenu]
public class OffensiveScript : ScriptableObject
{
    public enum Weapons
    {
        Sword,
        HandCannon,
        Whip,
        GreekFire,
        Gauntlets,
        Crossbow,
        
        
    }

    public Weapons CurrentWeapons;

    public void RunCurrentWeapons()
    {
        switch (CurrentWeapons)
        {
            case Weapons.Sword:
                break;
            case Weapons.HandCannon:
                break;
            case Weapons.Whip:
                break;
            case Weapons.GreekFire:
                break;
            case Weapons.Gauntlets:
                break;
            case Weapons.Crossbow:
                break;
            
        }
    }
}
