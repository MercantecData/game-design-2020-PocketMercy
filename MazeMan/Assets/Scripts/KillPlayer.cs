using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    private GameController gameController = GameController.instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            gameController.coins = 0;
            SceneManager.LoadScene("GameOver");
        }
        if(gameObject.tag != "Trap")
        {
            Destroy(this.gameObject);
        }
    }
}
