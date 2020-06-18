using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public GameObject projectilePrefab;
    public string mainState = "Patrol";
    public string currentState = "Patrol";

    public LayerMask mask;
    public float range = 15;
    public float speed;
    public Transform waypoint1;
    public Transform waypoint2;

    private bool timerStarted = false;
    private Transform nextwaypoint;
    private Timer timer;


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
            //Turn towards player
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            var playerPos = player.transform.position - transform.position;
            playerPos.z = 0;
            transform.right = playerPos;

            if(!timerStarted)
            {
                print("starting timer");
                StartTimer();
            }
            
            /*//Shoot only once pr sec
            if (Time.deltaTime >= nextTime)
            {
                Shoot();

                nextTime += Time.deltaTime;
            }*/

            if (!TargetAquired())
            {
                currentState = mainState;
                timer.Change(-1, -1); // Stop the timer from running.
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

    public void StartTimer()
    {
        TimerCallback tcb = Shoot;
        timer = new Timer(tcb, "shooting", TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));
        timerStarted = true;
        print("Timer started");
    }

    private void Shoot(object state)
    {
        //Shoot
        print(transform.position);
        print("wtf");
        Vector3 projectilePosition = transform.position;
        print("made position");
        GameObject projectile = Instantiate(projectilePrefab, projectilePosition, transform.rotation);
        print("initilaized");
        Rigidbody2D rigidbody = projectile.GetComponent<Rigidbody2D>();
        rigidbody.velocity = projectile.transform.right * 10;

        Destroy(projectile, 10);
    }

    public bool TargetAquired()
    {
        GameObject targetGO = GameObject.FindGameObjectWithTag("Player");
        bool inVision = false;

        //Check range
        if(Vector2.Distance(targetGO.transform.position, transform.position) > range)
        {
            return false;
        }

        //Check vision
        var linecast = Physics2D.Linecast(transform.position, targetGO.transform.position, mask);
        if(linecast.transform == null)
        {
            inVision = true;
        }

        return inVision;
    }
}
