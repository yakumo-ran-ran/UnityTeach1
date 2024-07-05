using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson9Ex : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform target= transform.CustomFind("TARGET");
        print(target.name); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
