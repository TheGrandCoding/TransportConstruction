using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Component))]
public class ComponentUI : Editor
{
    static bool showRequiredObjects = false;
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        var script = (Component)target;
        //Debug.Log("Doing for: " + script.Name);
        //GUILayout.TextField("Name", script.Name);
        if (GUILayout.Button("Log Base Components Needed"))
        {
            string log = "";
            var dict = script.GetTotalBaseComponents();
            foreach(var keypair in dict)
            {
                log += $"{keypair.Key.Name} : {keypair.Value}\r\n";
            }
            Debug.LogWarning($"For {script.Name}:\r\n{log}");
        }
    }
}
