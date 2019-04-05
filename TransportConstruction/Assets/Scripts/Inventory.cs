using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    static Inventory instance;
    private void Awake()
    {
        instance = this;
    }

    public static Dictionary<Component, int> Components = new Dictionary<Component, int>();

    static int _remove(Component c, int maximum = int.MaxValue)
    {
        int numRemoved = 0;
        if(Components.TryGetValue(c, out int numOfThisComponent))
        {
            while(numOfThisComponent > 0 && numRemoved < maximum)
            {
                numRemoved++;
                numOfThisComponent--;
            }
            Components[c] = numOfThisComponent;
        }
        return numRemoved;
    }

    static void _add(Component c)
    {
        if(Components.TryGetValue(c, out int amount))
        {
            Components[c] = amount + 1;
        } else
        {
            Components.Add(c, 1);
        }
    }


    public int Remove(Component c, int maximum = int.MaxValue) => _remove(c, maximum);

    public void Add(Component c) => _add(c);
}
