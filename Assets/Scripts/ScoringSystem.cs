using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoringSystem : MonoBehaviour
{

    public TextMeshProUGUI textScoreGame;
    public TextMeshProUGUI textScoreEnding;


    public float score = 0;

    private void Start()
    {
        score = 0;
    }

    public void  Scoreadd(float scoreBerapa)
    {
        score += scoreBerapa;
    }
    
}
