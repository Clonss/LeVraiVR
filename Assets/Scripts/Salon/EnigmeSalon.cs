using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmeSalon : MonoBehaviour
{
    public bool isTrue = false;

    public GameObject lights;
    public GameObject music;
    public GameObject ghost;

    private GameManager gameManager;

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
        music.SetActive(true);
        gameManager.ghostsNbr++;
    }
}
