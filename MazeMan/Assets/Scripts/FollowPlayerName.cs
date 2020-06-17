using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerName : MonoBehaviour
{
    public Transform player;

    public float offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        var playerPosition = player.position;

        transform.position = new Vector3(playerPosition.x, playerPosition.y + offset);
    }
}
