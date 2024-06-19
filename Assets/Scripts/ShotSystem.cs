using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSystem : MonoBehaviour
{
    public Rigidbody projectile;

    public float nextFire = 0.0f;

    public float speed = 300f;

    public Transform fireSpawn;


    void Update()
    {
        //Vector
        Vector3 forward = transform.forward;
      

        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            Rigidbody theProjectile = Instantiate(projectile, fireSpawn.transform.position, fireSpawn.transform.rotation);
            theProjectile.velocity = transform.forward * speed/60f;
        }
    }
}
