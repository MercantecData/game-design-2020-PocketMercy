using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text textfield = GetComponent<Text>();
        textfield.text = GameController.instance.playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
