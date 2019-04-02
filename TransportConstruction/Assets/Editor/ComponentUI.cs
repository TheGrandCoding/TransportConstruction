using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/*//[CustomEditor(typeof(Component))]
public class ComponentUI : Editor
{
    static bool showRequiredObjects = false;
    public override void OnInspectorGUI()
    {
        //DrawDefaultInspector();
        var script = (Component)target;
        //Debug.Log("Doing for: " + script.Name);
        //GUILayout.TextField("Name", script.Name);
        showRequiredObjects = EditorGUILayout.Foldout(showRequiredObjects, "Needed components");
        if(showRequiredObjects)
        {
            Editor editor = null;
            foreach(var component in script.RequiredComponents)
            {
                EditorGUI.indentLevel++;
                if (!editor)
                    Editor.CreateCachedEditor(component, typeof(RequireComponent), ref editor);
                editor.OnInspectorGUI();
                EditorGUI.indentLevel--;
            }
        }


        if (GUILayout.Button("New"))
        {
            Debug.Log("Thing for " + script.Name);
            script.AddNewRequirement();
        }
    }
}*/
