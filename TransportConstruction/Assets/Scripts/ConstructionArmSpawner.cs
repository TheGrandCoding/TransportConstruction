using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstructionArmSpawner : MonoBehaviour
{
    public GameObject armBase;
    public Vector3 scale = new Vector3(1.5f, 1.5f, 1);

    void Start()
    {
        GameObject newArmBase = Instantiate(armBase, transform.position, armBase.transform.rotation);
        newArmBase.transform.localScale = scale;
        newArmBase.transform.parent = gameObject.transform;
    }
}