using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPref : MonoBehaviour
{
    public string level;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("level", level);
        print(PlayerPrefs.GetString("level"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
