using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class DefensiveScript : ScriptableObject
{
    public enum Weapons
    {
        Shield,
        Helmet,
        Armor
    }
    
    public Weapons CurrentDefense;

    public void runcurrentdefense()
    {
        switch (CurrentDefense)
        {
            case Weapons.Shield:
                break;
            case Weapons.Helmet:
                break;
            case Weapons.Armor:
                break;
            
        }
    }

}

