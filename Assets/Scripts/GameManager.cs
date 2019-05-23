using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int ghostsNbr;

    public float maxTime;
    public float actualTime;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Set();
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    void Set()
    {
        maxTime = 1200;
        actualTime = maxTime;
        player = GameObject.Find("Player");
    }

    void Timer()
    {
        if (actualTime <= 0)
        {
            player.GetComponent<PlayerMoves>().enabled = false;
        }
        else
        {
            actualTime -= Time.deltaTime;
        }
    }
}
