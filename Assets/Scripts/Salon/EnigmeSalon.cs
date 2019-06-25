using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmeSalon : MonoBehaviour
{
    public bool isTrue = false;

    public GameObject lights;
    public GameObject music;
    public ParticleSystem Success;
    public AudioSource SuccessSound;

    private GameManager gameManager;

    public ParticleSystem daddy;
    public GameObject pathDaddy;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isTrue == true)
        {
            transform.Rotate(0, 0.5f, 0 * Time.deltaTime);
        }
    }

    public void Spin()
    {
        isTrue = true;
        lights.SetActive(true);
        music.SetActive(true);
        gameManager.ghostsNbr++;
        gameManager.unlockedDad = true;
        Success.transform.position = transform.position;
        Success.Play();
        SuccessSound.transform.position = transform.position;
        SuccessSound.Play();
        daddy.transform.position = transform.position;
        pathDaddy.SetActive(true);
    }
}
