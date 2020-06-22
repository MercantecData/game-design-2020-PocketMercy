using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
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
        if (collision.name == "Player")
        { 
            SceneManager.LoadScene("GameOver");
        }
        if(gameObject.tag != "Trap")
        {
            Destroy(this.gameObject);
        }
    }
}
