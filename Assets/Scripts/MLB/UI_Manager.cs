using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    //public GameObject statsScreen;
    //public Text timerText;
    //private float objectif = 1200f;
    //private float timerValue = 0f;
    public float timer = 0;
    public float timer_deux = 0;
    public GameObject fondu;
    public GameObject fonduFin;
    public GameObject livre;
    public GameObject levier;
    public int chiffre = 0;

    public static UI_Manager s_Singleton;


    private void Awake()
    {
        if(s_Singleton != null)
        {
            Destroy(gameObject);
        }
        else
        {
            s_Singleton = this;
        }
    }

    void Start()
    {
        
    }
    
    void Update()
    {

        /*if (timerValue < objectif)
        {
            timerValue += Time.deltaTime;
            UpdateTimerDisplay();
        }
        if(timerValue >= objectif)
        {
            DisplayStatsScreen();
        }
        */

        EndingGame();

        timer += Time.deltaTime;

        if (timer >= 2)
        {
            Destroy(fondu);
        }


        if(levier.GetComponent<LevierManager>().activation == true && levier == true)
        {
            fonduFin.SetActive(true);
        }
    }
    /*public void DisplayStatsScreen()
    {
        statsScreen.SetActive(true);
    }
    public void UpdateTimerDisplay()
    {
        timerText.text = timerValue.ToString("00:00");
    }

    public void ReturnMainMenu()
    {
        SceneManager.LoadScene(1);
    }
    */

    public void EndingGame()
    {
        if(livre == false && chiffre == 1)
        {
            fonduFin.SetActive(true);
            timer_deux += Time.deltaTime;
            if (timer_deux >= 3)
            {
                SceneManager.LoadScene(2);
            }
        }

        if(levier == true && levier.GetComponent<LevierManager>().activation == true)
        {
            fonduFin.SetActive(true);
            timer_deux += Time.deltaTime;
            if (timer_deux >= 3)
            {
                SceneManager.LoadScene(3);
            }
        }
    }
}
