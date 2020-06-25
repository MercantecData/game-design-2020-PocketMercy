using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCoinsFormController : MonoBehaviour
{
    private GameController gameController = GameController.instance;
    private int coins;
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
         text = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        coins = gameController.coins;

        if(coins >= 3)
        {
            text.text = "Coins: " + coins + "/3 Reload Speed Doubled!";
        }
        else
        {
            text.text = "Coins: " + coins + "/3";
        }
    }
}
