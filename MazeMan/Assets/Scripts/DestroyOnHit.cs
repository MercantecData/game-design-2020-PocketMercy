using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnHit : MonoBehaviour
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
        print("collition");
        if (collision.name != "Player" && collision.tag != "Wall")
        {
            Destroy(collision.gameObject);
        }
        Destroy(this.gameObject);
    }
}
