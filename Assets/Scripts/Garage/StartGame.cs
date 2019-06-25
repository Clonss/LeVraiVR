using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private float time;
    private bool leverActive;
    public FonduNoir player;

    // Start is called before the first frame update
    void Start()
    {
        time = 1;
        leverActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (leverActive)
        {
            time -= Time.deltaTime;
            player.fadeIn = true;
        }

        if (time <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void OnLeverActivated()
    {
        leverActive = true;
    }
}
