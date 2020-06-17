﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public GameObject projectilePrefab;
    public string mainState = "Patrol";
    public string currentState = "Patrol";
    private Transform nextwaypoint;

    public LayerMask mask;
    public float range = 15;
    public float speed;
    public Transform waypoint1;
    public Transform waypoint2;


    // Start is called before the first frame update
    void Start()
    {
        nextwaypoint = waypoint1;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentState == "Patrol")
        {
            Vector2 nextposition = Vector2.MoveTowards(transform.position, nextwaypoint.position, Time.deltaTime * speed);
            transform.position = nextposition;
            
            if(transform.position == nextwaypoint.position)
            { 
                if(nextwaypoint == waypoint1)
                {
                    nextwaypoint = waypoint2;
                }
                else
                {
                    nextwaypoint = waypoint1;
                }
            }
            
            if(TargetAquired())
            {
                currentState = "Attack";
            }
        }
        else if (currentState == "Attack")
        {
            //Shoot
            Vector3 projectilePosition = transform.position;
            GameObject projectile = Instantiate(projectilePrefab, projectilePosition, transform.rotation);
            Rigidbody2D rigidbody = projectile.GetComponent<Rigidbody2D>();
            rigidbody.velocity = projectile.transform.right * 10;
            Destroy(projectile, 10);

            if(!TargetAquired())
            {
                currentState = mainState;
            }
        }
        else if(currentState == "Lookout")
        {
            if (TargetAquired())
            {
                currentState = "Attack";
            }
        }
    }

    public bool TargetAquired()
    {
        GameObject targetGO = GameObject.FindGameObjectWithTag("Player");
        bool inRange = false;
        bool inVision = false;

        //Check range
        if(Vector2.Distance(targetGO.transform.position, transform.position) < range)
        {
            inRange = true;
        }

        //Check vision
        var linecast = Physics2D.Linecast(transform.position, targetGO.transform.position, mask);
        if(linecast.transform == null)
        {
            inVision = true;
        }

        return inRange && inVision;
    }
}