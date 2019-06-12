using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmeChambre : MonoBehaviour
{
    public int count;
    public bool validated;
    private GameManager gameManager;
    public GameObject VFX;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        validated = false;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Verify();
    }

    void Verify()
    {
        if(count == 3)
        {
            validated = true;
            //VFX.SetActive(true);
            count = 0;
            gameManager.ghostsNbr++;
        }
    }
}
