﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtMaus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var mousePos = Input.mousePosition;
        var mousePosWorld = Camera.main.ScreenToWorldPoint(mousePos);

        var foxToMousePosition = mousePosWorld - transform.position;

        foxToMousePosition.z = 0;

        transform.right = foxToMousePosition;
    }
}
