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
    public GameObject logo;

    // Start is called before the first frame update
    void Start()
    {
        time = 8;
        fondu = GameObject.Find("VRFadeCanvas").GetComponent<FonduNoir>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        logo = GameObject.Find("LogoVR");
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
            logo.SetActive(true);
        }

        if (time <= 0)
        {
            Application.Quit();
        }
    }
}
