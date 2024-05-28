using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aaa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Myvector m1 = new Myvector(1, 2);
        Mys m2 = new Mys(3, 4);
        m2.x = 5;
        m2.y = 6;
        Debug.Log("myvector" + m1.x + m1.y);
        Debug.Log("myvector" + m2.x + m2.y);

    }

    // Update is called once per frame
    void Update()
    {

    }

    class Myvector
    {
        public float x;
        public float y;

        public Myvector(float x, float y)
        {
            this.x = x;
            this.y = y;




        }
        





    }
    struct Mys
    {
        public float x;
        public float y;

        public Mys(float x, float y)
        {
            this.x = x;
            this.y = y;




        }


    }
}

