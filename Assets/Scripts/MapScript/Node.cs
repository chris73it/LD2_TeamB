using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public NodeData nodeData;
    public NodeSystem system;

    public void  OnNodeComplete()
    {
        nodeData.isComplete = true;
       foreach (int nodeIndex in system.unlockedNodes)
       {
           NodeSystem.UnlockNode(nodeIndex);
        }
    }
}
