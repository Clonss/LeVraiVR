using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public GameObject statsScreen;
    public Text timerText;
    private float objectif = 1200f;
    private float timerValue = 0f;
    public float timer = 0;
    public float timer_deux = 0;
    public GameObject fondu;
    public GameObject livre;
    public GameObject mainScene;

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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timerValue < objectif)
        {
            timerValue += Time.deltaTime;
            UpdateTimerDisplay();
        }
        if(timerValue >= objectif)
        {
            DisplayStatsScreen();
        }
        if(timer >= 2)
        {
            Destroy(fondu);
        }

        if(livre == false && mainScene == true)
        {
            timer_deux += Time.deltaTime;
            if (timer_deux >= 2)
            {
                SceneManager.LoadScene(2);
            }
        }
    }
    public void DisplayStatsScreen()
    {
        statsScreen.SetActive(true);
    }
    public void UpdateTimerDisplay()
    {
        timerText.text = timerValue.ToString("00:00");
    }

    public void ReturnMainMenu()
    {
        //SceneManager.LoadScene("SceneMaxG", LoadSceneMode.Additive);
        //Application.LoadLevel("SceneMaxG");
        SceneManager.LoadScene(1);
    }
}
