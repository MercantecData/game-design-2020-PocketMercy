using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void Retry()
    {
        var level = PlayerPrefs.GetString("level");
        SceneManager.LoadScene(level);
    }
    public void ChangeScene(string sceneName)
    {
        PlayerPrefs.SetString("level", "Level 1");
        SceneManager.LoadScene(sceneName);
    }
    public void NextLevel()
    {
        if(PlayerPrefs.GetString("level") == "Level 1")
        {
            PlayerPrefs.SetString("level", "Level 2");
            SceneManager.LoadScene("Level 2");
        }
        else if (PlayerPrefs.GetString("level") == "Level 2")
        {
            SceneManager.LoadScene("EndWinScreen");
        }
    }
}
