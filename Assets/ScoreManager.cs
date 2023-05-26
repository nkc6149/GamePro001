using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    GameObject scoreobj;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text scoretext = scoreobj.GetComponent<Text>();

        scoretext.text = "000000km";
    }
}
