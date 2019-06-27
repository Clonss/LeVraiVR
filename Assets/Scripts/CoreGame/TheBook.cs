using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheBook : MonoBehaviour
{
    private GameManager gameManager;

    public GameObject dadDecouvert;
    public GameObject dadNonDecouvert;
    public GameObject momDecouvert;
    public GameObject momNonDecouvert;
    public GameObject auntDecouvert;
    public GameObject auntNonDecouvert;
    public GameObject gmDecouvert;
    public GameObject gmNonDecouvert;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        UnlockPages();
    }

    void UnlockPages()
    {
        if (gameManager.unlockedDad == true)
        {
            dadDecouvert.SetActive(true);
            dadNonDecouvert.SetActive(false);
        }
        if (gameManager.unlockedMom == true)
        {
            momDecouvert.SetActive(true);
            momNonDecouvert.SetActive(false);
        }
        if (gameManager.unlockedAunt == true)
        {
            auntDecouvert.SetActive(true);
            auntNonDecouvert.SetActive(false);
        }
        if (gameManager.unlockedGrandma == true)
        {
            gmDecouvert.SetActive(true);
            gmNonDecouvert.SetActive(false);
        }
    }
}
