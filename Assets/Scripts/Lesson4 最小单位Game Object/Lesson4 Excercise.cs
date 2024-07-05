using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4Excercise : MonoBehaviour
{
    public GameObject tank;
    // Start is called before the first frame update
    void Start()
    {
        GameObject tankObj = Instantiate(tank);
        tankObj.name = "坦克";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
