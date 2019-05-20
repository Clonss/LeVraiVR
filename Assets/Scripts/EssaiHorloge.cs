using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EssaiHorloge : MonoBehaviour
{
    private Vector3 rotationH;

    // Start is called before the first frame update
    void Start()
    {
        rotationH = Vector3.zero;
        rotationH.x = 0.25f;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(rotationH * Time.deltaTime);
    }
}
