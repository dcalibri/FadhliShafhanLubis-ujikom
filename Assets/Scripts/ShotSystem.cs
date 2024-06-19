using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSystem : MonoBehaviour
{
    public Rigidbody projectile;

    public float nextFire = 0.0f;

    public float speed = 4;

    public Transform fireSpawn;


    void Update()
    {
      
      

        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            Rigidbody theProjectile = Instantiate(projectile, transform.position, transform.rotation);
            theProjectile.velocity = transform.forward * speed;
        }
    }
}
