using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject TimeGauge;
  
    void Start()
    {
        this.TimeGauge = GameObject.Find("TimeGauge");
    }

    private void Update()
    {
        this.TimeGauge.GetComponent<Image>().fillAmount -= 1.0f / 6000.0f;
        if (this.TimeGauge.GetComponent<Image>().fillAmount == 0)
        {
            SceneManager.LoadScene("TitleScene");
        }
    }

    public void DecreaseTime()
    {
        this.TimeGauge.GetComponent<Image>().fillAmount -= 0.1f;
        if (this.TimeGauge.GetComponent<Image>().fillAmount == 0)
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}
