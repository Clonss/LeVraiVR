﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    public GameObject[] PathNode;
    public GameObject PS;
    public float MoveSpeed;
    float Timer;
    static Vector3 CurrentPositionHolder;
    int CurrentNode;
    private Vector2 startPosition;


    // Use this for initialization
    void Start()
    {
        CheckNode();

    }

    void CheckNode()
    {
        Timer = 0;
        startPosition = PS.transform.position;
        CurrentPositionHolder = PathNode[CurrentNode].transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        Timer += Time.deltaTime * MoveSpeed;

        if (PS.transform.position != CurrentPositionHolder)
        {

            PS.transform.position = Vector3.MoveTowards(startPosition, CurrentPositionHolder, Timer);
        }
        else
        {

            if (CurrentNode < PathNode.Length - 1)
            {
                CurrentNode++;
                CheckNode();
            }
        }
    }
}
