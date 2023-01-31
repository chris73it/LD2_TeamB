using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/TroopInventory", order = 2)]
public class Troops : ScriptableObject
{
    List<Troop> troops;

    public void addTroop(Troop newTroop)
    {
        troops.Add(newTroop);
    }

    public void removeTroop(Troop remTroop)
    {
        troops.Remove(remTroop);
    }
}
