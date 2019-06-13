using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorlogeHeure : MonoBehaviour
{
    private Vector3 heures;

    // Start is called before the first frame update
    void Start()
    {
        heures = Vector3.zero;
        heures.x = 0.25f;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(heures * Time.deltaTime);
    }
}
