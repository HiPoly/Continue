using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private float LaunchSpeed = 0;
    private Rigidbody rb;
    [SerializeField]
    private float pauseTime = 0;
    private bool inPlay = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Launch()
    {
        {
            if (inPlay == false)
            {
                inPlay = true;
                rb.isKinematic = false;
                rb.AddForce(new Vector3(LaunchSpeed, 0, 0));
                foreach (var Movable in FindObjectsOfType<Movable>())
                {
                    Movable.LockGame();
                }
            }
        }
    }

    private void OnCollisionEnter(Collision Collision)
    {
        if (Collision.gameObject.tag == "Sticky")
        {
            {
                StartCoroutine(Stick());
            }
        }
    }
    IEnumerator Stick()
    {
        rb.velocity = Vector3.zero;
        rb.useGravity = false;
        yield return new WaitForSeconds(pauseTime);
        rb.useGravity = true;
    }

}
