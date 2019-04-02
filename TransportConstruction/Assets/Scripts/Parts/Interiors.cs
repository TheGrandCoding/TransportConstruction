using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Interior", menuName = "Parts/Interior")]
public class Interiors : ScriptableObject
{
    public ScriptableObject dashboard;
    public ScriptableObject wheel;
    public ScriptableObject gaugeSpeed;
    public ScriptableObject gaugeFuel;
    public ScriptableObject screen;
}
