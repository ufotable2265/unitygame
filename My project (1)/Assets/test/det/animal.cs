using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animal
{
    public string name;
    public string sound;
    private void Start()
    {
        PlatSound();
    }
    public void PlatSound()
    {
        Debug.Log(name + ":" + sound);


    }
}

