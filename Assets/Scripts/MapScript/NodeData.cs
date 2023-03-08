using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/DataNode")]
public class NodeData : ScriptableObject
{
    public string nodeName;
    public bool isComplete = false;
    public List<int> unlockNodes;
}
