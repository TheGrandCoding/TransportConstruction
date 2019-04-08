using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveryorBelt : MonoBehaviour
{
    public GameObject belt;
    public Transform endpoint;
    public float speed = 1f;

    private void Start()
    {
        belt = this.gameObject;
        endpoint = transform.Find("Endpoint");
    }

    private void OnTriggerStay(Collider other)
    {
        other.transform.position = Vector3.MoveTowards(other.transform.position, endpoint.position, speed * Time.deltaTime);
    }
}
