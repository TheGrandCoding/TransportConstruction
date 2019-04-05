using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine : MonoBehaviour
{
    public string Name;

    public bool CanProduce(Component[] itemsIn, Component wantedOut)
    {
        if(wantedOut.Machine == Name)
        {
            List<Component> needed = wantedOut.Components;
            foreach (var c in itemsIn)
                needed.Remove(c);
            return needed.Count == 0;
        }
        return false;
    }


    public bool Produce(Inventory inventory, Component wantedComponent, Component[] itemsIn)
    {
        if(CanProduce(itemsIn, wantedComponent))
        {
            foreach(var c in itemsIn)
            {
                inventory.Remove(c, 1);
            }
            inventory.Add(wantedComponent);
            return true;
        }
        return false;
    }
}
