using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereConroller : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = 1234;
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0,0,250f);
    }
}
