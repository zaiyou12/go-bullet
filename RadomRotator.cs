using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadomRotator : MonoBehaviour
{
    public float tumble;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = Random.insideUnitSphere * tumble;
    }
}
