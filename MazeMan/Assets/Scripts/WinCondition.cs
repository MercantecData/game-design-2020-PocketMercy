using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public GameObject[] BossEnemys;

    private int Dead = 0;
    private int quantity = 0;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject BossEnemy in BossEnemys)
        {
            quantity += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Dead = 0;

        foreach(GameObject BossEnemy in BossEnemys)
        {
            if (BossEnemy == null)
            {
                Dead += 1;
            }
        }

        if (Dead == quantity)
        {
            print("you won");
        }
    }
}
