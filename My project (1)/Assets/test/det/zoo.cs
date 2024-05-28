using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        animal tom = new animal();
        tom.name = "tom";
        tom.sound = "具克";

        animal jerry = new animal();
        jerry.name = "力府";
        jerry.sound = "⿶⿶";



        jerry = tom;


        tom.PlatSound();
        jerry.PlatSound();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
