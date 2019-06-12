using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmeSalleDeBain : MonoBehaviour
{
    public int count;

    private bool validated;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Check();
    }

    void Check()
    {
        if (count >= 5 && validated == false)
        {
            gameManager.ghostsNbr++;
            count = 0;
            validated = true;
        }
    }
}
