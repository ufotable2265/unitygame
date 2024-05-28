using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Transform ct;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -1, 0);

        ct.localPosition = new Vector3(0, 2, 0);

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 30));
        ct.localRotation = Quaternion.Euler(new Vector3(0, 60, 0));

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime);
        }
    }
}
