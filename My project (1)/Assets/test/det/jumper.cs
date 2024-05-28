using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumper : MonoBehaviour
{
    Rigidbody rb;
    public float power;
    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rb.AddForce(0, power, 0);
    }


}
