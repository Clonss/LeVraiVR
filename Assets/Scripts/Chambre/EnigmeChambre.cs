using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmeChambre : MonoBehaviour
{
    public int count;
    public bool validated;
    private GameManager gameManager;

    public ParticleSystem VFXSuccess;
    public AudioSource SuccessSound;

    public PathFollower path;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        validated = false;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        path = GetComponent<PathFollower>();
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
            count = 0;
            gameManager.ghostsNbr++;
            gameManager.unlockedMom = true;
            VFXSuccess.transform.position = transform.position;
            VFXSuccess.Play();
            SuccessSound.transform.position = transform.position;
            SuccessSound.Play();
        }
    }
}
