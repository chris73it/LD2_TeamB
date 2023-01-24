using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/TroopInventory", order = 2)]
public class Troops : ScriptableObject
{
    List<Troop> troops;

    void addTroop(Troop newTroop)
    {
        troops.Add(newTroop);
    }

    void removeTroop(Troop remTroop)
    {
        troops.Remove(remTroop);
    }
}
