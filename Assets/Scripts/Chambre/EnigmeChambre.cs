using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmeChambre : MonoBehaviour
{
    public int count;
    public bool validated;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        validated = false;
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
        }
        else
        {
            validated = false;
        }
    }
}
