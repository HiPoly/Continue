using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedy : MonoBehaviour
{
    public GameObject Ball;
    private Rigidbody rb;
    public float boost;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collider)
    {
        var body = collider.GetComponent<Rigidbody>();
        body.velocity = body.velocity * boost;
    }
}
