using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disque : MonoBehaviour
{
    public bool isTrue = false;
    public GameObject spot;
    public GameObject music;
    public GameObject cochon;

    // Start is called before the first frame update
    void Start()
    {
        
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
        spot.SetActive(true);
        music.SetActive(true);
        cochon.SetActive(true);
    }
}
