using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevierManager : MonoBehaviour
{
    public GameObject fondu;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(fondu.active == true)
        {
            timer += Time.deltaTime;
        }
        if (timer >= 2)
        {
            SceneManager.LoadScene(3);
        }
    }

    public void OnleverDown()
    {
        fondu.SetActive(true);
    }
}
