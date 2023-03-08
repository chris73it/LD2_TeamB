using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/node")]
public class Node : ScriptableObject
{

    public List<GameObject> nodes;


    public bool IsCompleted;


}
