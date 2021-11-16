using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerX : MonoBehaviour
{
    private float countDown = 3;
    public TextMeshProUGUI timerText;
    private GameManagerX gameManagerX;

    private void Start()
    {
        gameManagerX = GameObject.Find("Game Manager").GetComponent<GameManagerX>();
    }

    public void TimerCoundown()
    {
        if (gameManagerX.isGameActive)
        {
            if (countDown > 0)
            {
                countDown -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time Out!");
                
            }

            timerText.text = "Timer: " + countDown; //timer needs to be readable 

        }

    }

    public void Update()
    {
        TimerCoundown();
    }



}