using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addSco : MonoBehaviour
{
    public Text scoreTxt;
    public int score = 0;

   
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
    }
}
