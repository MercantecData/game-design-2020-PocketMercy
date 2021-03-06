﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Events;

public class GunReloadUI : MonoBehaviour
{
    private GameController gameController = GameController.instance;
    public Slider reloadBar;
    public Text displayText;
    public float reloadingTime;

    private float currentValue;
    private bool reloading;
    public float CurrentValue
    {
        get
        {
            return currentValue;
        }
        set
        {
            currentValue = value;
            reloadBar.value = currentValue;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
        CurrentValue = reloadingTime;
        reloading = false;
    }

    // Update is called once per frame
    void Update()
    {
        reloadingTime = gameController.reloadSpeed;
        if (reloading)
        {
            CurrentValue += Time.deltaTime;

            if (currentValue >= reloadingTime)
            {
                reloading = false;
                displayText.text = "Reloaded";
            }
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            if (!reloading)
            {
                CurrentValue = 0;
                reloading = true;
                displayText.text = "Reloading...";
            }
        }
    }
}
