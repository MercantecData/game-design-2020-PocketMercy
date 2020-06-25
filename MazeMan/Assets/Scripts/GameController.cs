using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public string level;
    public string playerName;
    public float reloadSpeed = 1f;
    public int coins = 0;

    private bool done = false;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(coins >= 3 && !done)
        {
            reloadSpeed = 0.5f;
            done = true;
        }
    }
    private void Awake()
    {
        instance = this;
    }
}
