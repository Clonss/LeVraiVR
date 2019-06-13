using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    public GameObject target;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 dir = (target.transform.position - this.transform.position).normalized;
        this.transform.position = dir * Time.deltaTime;
    }
}
