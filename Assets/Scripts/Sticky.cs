using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sticky : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private bool pauseTime;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider collider)
    {
        StartCoroutine(Stick());
    }

    IEnumerator Stick()
    {
        rb.velocity = Vector3.zero;
        rb.useGravity = false;
        //WaitForSeconds(pauseTime);
        yield return null;
    }
}
