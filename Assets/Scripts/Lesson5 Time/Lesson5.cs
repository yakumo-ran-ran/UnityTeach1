using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Time.timeScale = 0;
        // Time.timeScale = 0.5f;
        // Time.timeScale = 1;
        // Time.timeScale = 2;
        // //
        // // print("帧间隔时间"+Time.deltaTime);
        // // print("不受scale影响的帧间隔时间" + Time.unscaledDeltaTime);
        // print("Time.time"+Time.time);
        // print(Time.unscaledTime);
        print(Time.frameCount);
    }

    private void FixedUpdate()
    {
        // print(Time.fixedDeltaTime);
        // print(Time.unscaledDeltaTime);
    }
}
