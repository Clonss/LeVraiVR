using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endgame : MonoBehaviour
{
    private float time;
    private bool end;
    public FonduNoir player;

    // Start is called before the first frame update
    void Start()
    {
        time = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            end = true;
        }

        if (end)
        {
            time -= Time.deltaTime;
            player.fadeIn = true;
        }

        if (time <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
