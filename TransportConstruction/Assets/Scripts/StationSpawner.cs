using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationSpawner : MonoBehaviour
{
    public GameObject armBase;
    public Vector3 armScale = new Vector3(1.5f, 1.5f, 1);

    public GameObject belt;
    public Vector3 beltScale = new Vector3(1.5f, 0.1f, 5f);

    void Start()
    {
        SpawnStation();
    }

    public void SpawnStation()
    {
        if (gameObject.tag == "Conveyor Belt")
        {
            SpawnBelt();
        }
        else if (gameObject.tag == "Construction Arm")
        {
            SpawnBase();
        }
    }

    private void SpawnBase()
    {
        GameObject newArmBase = Instantiate(armBase, transform.position, armBase.transform.rotation);
        newArmBase.transform.localScale = armScale;
        newArmBase.transform.parent = gameObject.transform;
    }

    private void SpawnBelt()
    {
        GameObject newBelt = Instantiate(belt, transform.position, belt.transform.rotation);
        newBelt.transform.localScale = beltScale;
        newBelt.transform.parent = gameObject.transform;
    }
}