using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmeSalleDeBain : MonoBehaviour
{
    public int count;

    private bool validated;

    private GameManager gameManager;

    public ParticleSystem VFX;
    public AudioSource SuccessSound;
    public GameObject bottle;

    public ParticleSystem aunt;
    public GameObject pathAunt;
    public GameObject lavabo;

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
            gameManager.unlockedAunt = true;
            VFX.transform.position = bottle.transform.position;
            VFX.Play();
            SuccessSound.transform.position = bottle.transform.position;
            SuccessSound.Play();
            aunt.transform.position = lavabo.transform.position;
            pathAunt.SetActive(true);
        }
    }
}
