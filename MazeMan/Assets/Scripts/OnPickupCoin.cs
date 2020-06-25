using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPickupCoin : MonoBehaviour
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

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Player")
        {
            gameController.coins += 1;
            Destroy(this.gameObject);
        }
    }
}
