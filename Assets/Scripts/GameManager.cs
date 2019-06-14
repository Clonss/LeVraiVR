using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int ghostsNbr;

    public float maxTime;
    public float actualTime;

    public bool unlockedDad = false;
    public bool unlockedMom = false;
    public bool unlockedGrandma = false;
    public bool unlockedAunt = false;

    public GameObject dadDecouvert;
    public GameObject dadNonDecouvert;
    public GameObject momDecouvert;
    public GameObject momNonDecouvert;
    public GameObject auntDecouvert;
    public GameObject auntNonDecouvert;
    public GameObject gmDecouvert;
    public GameObject gmNonDecouvert;

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
        UnlockPages();
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
    public void UnlockPages()
    {



        if(unlockedDad == true)
        {
            dadDecouvert.SetActive(true);
            dadNonDecouvert.SetActive(false);
        }
        if (unlockedMom == true)
        {
            momDecouvert.SetActive(true);
            momNonDecouvert.SetActive(false);
        }
        if (unlockedAunt == true)
        {
            auntDecouvert.SetActive(true);
            auntNonDecouvert.SetActive(false);
        }
        if (unlockedGrandma == true)
        {
            gmDecouvert.SetActive(true);
            gmNonDecouvert.SetActive(false);
        }
    }
}
