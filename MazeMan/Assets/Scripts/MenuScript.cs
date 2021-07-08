using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void Retry()
    {
        var level = GameController.instance.level;
        SceneManager.LoadScene(level);
    }
    public void StartGame()
    {
        GameController.instance.level = "Level 1";
        SceneManager.LoadScene("Level 1");
    }
    public void NextLevel()
    {
        if(GameController.instance.level == "Level 1")
        {
            GameController.instance.level = "Level 2";
            SceneManager.LoadScene("Level 2");
        }
        else if (GameController.instance.level == "Level 2")
        {
            SceneManager.LoadScene("EndWinScreen");
        }
    }
}
