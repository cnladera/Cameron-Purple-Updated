﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        //rotate object on the x axis
        transform.Rotate(Vector3.forward, Time.deltaTime * 30f);
    }
}
