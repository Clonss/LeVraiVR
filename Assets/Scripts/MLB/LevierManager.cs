using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevierManager : MonoBehaviour
{
    public float timer;
    public bool activation = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(activation == true)
        {
            timer += Time.deltaTime;
        }
        if (timer >= 3)
        {
            SceneManager.LoadScene(3);
        }
    }

    public void OnleverDown()
    {
        activation = true;
    }
}
