using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject ingr1;

    void Start()
    {
        ingr1.gameObject.AddComponent<TakeIt>();
    }

    void Update()
    {

    }
}
