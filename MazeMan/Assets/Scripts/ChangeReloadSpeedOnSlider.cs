using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeReloadSpeedOnSlider : MonoBehaviour
{
    private Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = gameObject.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        var reloadSpeed = GameController.instance.reloadSpeed;
        
        slider.maxValue = reloadSpeed;
    }
}
