using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NodeSystem : MonoBehaviour
{
    public static NodeSystem instance;
    public List<int> unlockedNodes;
    public List<int> lockedNodes;
    // VVV store a ref of all of your nodeData here, so node system can use it, you dont have to do this, it can be convenient later on
    public List<NodeData> nodeDatabase;

    private void Awake()
    {

        //Singleton pattern, only have one instance of the class at all time
        if (instance != null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    public static void UnlockNode(int nodeIndex)
    {

        if (instance.lockedNodes.Contains(nodeIndex))
        {
           // insert code here to move the node to unlockedNodes
            instance.lockedNodes.Remove(nodeIndex);
            instance.unlockedNodes.Add(nodeIndex);
           instance.ShowUnlockNode(nodeIndex);
        }
    }

    public void ShowUnlockNode(int nodeIndex)
    {
        // play animation or whatever you need to do to show this new node is unlocked.
    }
}