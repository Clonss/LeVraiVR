using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EssaiMinute : MonoBehaviour
{
    private Vector3 minutes;

    // Start is called before the first frame update
    void Start()
    {
        minutes = Vector3.zero;
        minutes.x = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(minutes * Time.deltaTime);
    }
}
