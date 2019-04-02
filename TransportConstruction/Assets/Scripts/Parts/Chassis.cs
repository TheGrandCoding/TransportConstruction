using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Chassis", menuName = "Parts/Chassis")]
public class Chassis : ScriptableObject
{
    public ScriptableObject driveShaft;
    public ScriptableObject tyre1;
    public ScriptableObject tyre2;
    public ScriptableObject tyre3;
    public ScriptableObject tyre4;
    public ScriptableObject axelF;
    public ScriptableObject axelB;
    public ScriptableObject suspension1;
    public ScriptableObject suspension2;
    public ScriptableObject suspension3;
    public ScriptableObject suspension4;
    public ScriptableObject exhaust;
}
