using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    GameObject Score;
    float km ;

    void Start()
    {
        this.Score = GameObject.Find("Score");
       
    }

    void Update()
    {
        km++;
        this.Score.GetComponent<Text>().text = km + "Km";
    }
}
