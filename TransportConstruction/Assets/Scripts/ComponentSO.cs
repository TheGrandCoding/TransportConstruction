using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "New Component", menuName = "Component")]
public class ComponentSO : ScriptableObject
{
    [SerializeField]
    private string _name;
    /// <summary>
    /// Name of the Component
    /// </summary>
    [SerializeField]
    public string Name
    {
        get
        {
            if(string.IsNullOrWhiteSpace(_name))
            {
                Debug.LogWarning("Name not set for " + this.name);
                _name = this.name;
            }
            return _name;
        }   set { _name = value; }
    }
    /// <summary>
    /// Model of the Component
    /// </summary>
    public GameObject Object;
    /// <summary>
    /// Seconds taken to build this thing
    /// </summary>
    public int TimeToBuild;
    /// <summary>
    /// Machine the thing is built in(?)
    /// </summary>
    public string Machine;

    /// <summary>
    /// Things needed to build this
    /// </summary>
    public List<ComponentSO> Components = new List<ComponentSO>();


    public int GetNumberFor(ComponentSO c)
    { // find number of components *where* they are c
        return Components.Where(x => x.Name == c.Name).Count();
    }

    private Dictionary<ComponentSO, int> _cachedComponents;
    public Dictionary<ComponentSO, int> GetAllComponents()
    {
        if(_cachedComponents == null)
        {
            _cachedComponents = new Dictionary<ComponentSO, int>();
            foreach(var c in Components)
            {
                if (_cachedComponents.ContainsKey(c))
                    continue; // don't add twice
                _cachedComponents.Add(c, GetNumberFor(c));
            }
        }
        return _cachedComponents;
    }

    public int GetNumberFor(string c)
    { // find number of components *where* their name is c
        return Components.Where(x => x.name == c).Count();
    }

    public Dictionary<string, int> GetAllStringComponents()
    {
        var components = GetAllComponents();
        return components
            .Select(x => new KeyValuePair<string, int>(x.Key.Name, x.Value)) // gets just the name of the component
            .ToDictionary(o => o.Key, o => o.Value); // converts it to Dictionary, as the Select is a weird type
    }

    /// <summary>
    /// Finds the list of base components that it needs to make this
    /// 'Base Component' is one that doesnt need anything to make it
    /// </summary>
    public Dictionary<ComponentSO, int> GetTotalBaseComponents()
    {
        if (this.Components.Count == 0)
            return new Dictionary<ComponentSO, int>() { { this, 1 } };

        var dict = new Dictionary<ComponentSO, int>();
        foreach(var c in Components)
        {
            var componentDict = c.GetTotalBaseComponents();
            foreach(var keypair in componentDict)
            {
                if(dict.ContainsKey(keypair.Key))
                {
                    dict[keypair.Key] += keypair.Value; // add the existing vale
                } else
                {
                    dict.Add(keypair.Key, keypair.Value);
                }
            }
        }
        return dict;
    }
}
