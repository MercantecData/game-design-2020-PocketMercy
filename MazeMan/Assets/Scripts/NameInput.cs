using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void SetName(string inputname)
    {
        PlayerPrefs.SetString("playername", inputname);
    }
}
