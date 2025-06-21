using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> invItems = new List<GameObject>();

    public void AddItem(IItem item)
    {
        invItems.Add(item.Obj);
    }
}
