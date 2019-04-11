using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(ComponentSO))]
public class ComponentGO : MonoBehaviour
{
    private Rigidbody rb;
    public ComponentSO component;

	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        component = GetComponent<ComponentSO>();
	}
}
