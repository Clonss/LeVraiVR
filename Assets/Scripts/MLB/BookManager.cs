using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BookManager : MonoBehaviour
{
    public GameObject end;
    public GameObject feu;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Feu"))
        {
            Destroy(gameObject);
            Destroy(feu.GetComponent<AudioSource>());
            
        }
    }
    private void OnDestroy()
    {
        end.GetComponent<UI_Manager>().chiffre = 1;
    }
}
