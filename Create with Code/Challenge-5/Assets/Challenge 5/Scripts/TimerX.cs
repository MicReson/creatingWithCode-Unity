using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerX : MonoBehaviour
{
    private float countDown = 60f; //Number of seconds
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
                gameManagerX.GameOver();
                
            }

            float numberSeconds = Mathf.Round(countDown);//Rounding number to show seconds on the GUI

            timerText.text = "Timer: " + numberSeconds; 

        }

    }

    public void Update()
    {
        TimerCoundown();
    }



}