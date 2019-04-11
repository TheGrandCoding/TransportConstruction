using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveryorBelt : MonoBehaviour
{
    public Transform endpoint;
    public float speed = 1f;

    private void Start()
    {
        endpoint = transform.Find("Endpoint");
    }

    private void OnTriggerStay(Collider _other)
    {
        _other.transform.position = Vector3.MoveTowards(_other.transform.position, endpoint.position, speed * Time.deltaTime);
    }
}
