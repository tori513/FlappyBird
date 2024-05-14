using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addSco : MonoBehaviour
{
    public Text scoreTxt;
    public int score = 0;
    public GameObject bronzeMedal;
    public GameObject silverMedal;
    public GameObject goldMedal;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore()
    {
        score++;
        scoreTxt.text = score.ToString();
        

        if (score >= 20)
        {
            bronzeMedal.SetActive(true);
        }
        else if (score >= 50)
        {
            silverMedal.SetActive(true);
        }
        else if (score >= 100)
        {
            goldMedal.SetActive(true);
        }

    }
}
