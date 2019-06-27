using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endgame : MonoBehaviour
{
    private float time;
    public bool end;
    public FonduNoir fondu;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        time = 1;
        fondu = GameObject.Find("VRFadeCanvas").GetComponent<FonduNoir>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Leave();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Book") && gameManager.unlockedAll)
        {
            end = true;
        }
    }

    void Leave()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            end = true;
        }

        if (end)
        {
            time -= Time.deltaTime;
            fondu.fadeIn = true;
        }

        if (time <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
