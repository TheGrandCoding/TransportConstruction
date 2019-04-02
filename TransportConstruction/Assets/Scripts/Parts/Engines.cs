using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Engine", menuName = "Parts/Engine")]
public class Engines : ScriptableObject
{
    public ScriptableObject sparkPlug;
    public ScriptableObject valve;
    public ScriptableObject piston;
    public ScriptableObject pistonRing1;
    public ScriptableObject pistonRing2;
    public ScriptableObject pistonRing3;
    public ScriptableObject connectingRod;
    public ScriptableObject crankshaft;
    public ScriptableObject sump;
}
