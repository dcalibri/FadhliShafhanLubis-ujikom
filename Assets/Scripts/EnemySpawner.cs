using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform endLeft;
    public Transform endRight;

    public float speed = 4;

    public Rigidbody projectile;
    //public Rigidbody[] projectile;

    public float nextFire = 3f;
    private float timer;

    void Start()
    {
        timer = 0;
    }

    void Update()
    {
        timer++;

        if (Time.time > nextFire)
        {
            //Vector3 RandomPoints(endLeft - endRight);
            timer = 0;


            Rigidbody theProjectile = Instantiate(projectile, transform.position, transform.rotation);
            theProjectile.velocity = transform.forward * speed;
        }
    }
}
