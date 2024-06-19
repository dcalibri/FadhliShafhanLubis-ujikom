using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float heath = 300f;

    public float damage = 25;
    private ScoringSystem scoreSystem;

    private Collider Collider;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            heath = heath - damage;
            if(heath <= 0)
            {
                scoreSystem.AddScore(30);
            }


        }
       
    }


}
