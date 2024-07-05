using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    protected virtual void Awake()
    {
        print("Awake");
    }

    private void OnEnable()
    {
        print("Enable");
    }

    private void Start()
    {
        print("Start");
    }

    private void FixedUpdate()
    {
        print("FixedUpdate");
    }

    private void Update()
    {
        print("Update");
    }

    private void LateUpdate()
    {
        print("LateUpdate");
    }

    private void OnDisable()
    {
        print("OnDisable");
    }

    private void OnDestroy()
    {
        print("OnDestroy"); 
    }
}
