using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private GameController gameController = GameController.instance;
    public GameObject bulletPrefab;
    public int bulletSpeed = 10;
    public float reloadSpeed;
    private float nextTime = 0;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponentInChildren<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        reloadSpeed = gameController.reloadSpeed;
        if(Input.GetMouseButtonDown(0))
        {
            if (Time.time >= nextTime)
            {
                Vector3 bulletPosition = transform.position;

                GameObject bullet = Instantiate(bulletPrefab, bulletPosition, transform.rotation);

                Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();
                rigidbody.velocity = bullet.transform.right * bulletSpeed;

                audioSource.Play();

                Destroy(bullet, 10);

                nextTime = Time.time + reloadSpeed;
            }
        }
    }
}
