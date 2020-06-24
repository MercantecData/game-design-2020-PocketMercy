using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameInput : MonoBehaviour
{
    public GameObject GameController;
    private GameController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameController.GetComponent<GameController>();
    }

    public void SetName(string inputname)
    {
        controller.playerName = inputname;
    }
}
