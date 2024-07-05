using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Resolution r = Screen.currentResolution;
        print(r.height+""+r.width+""+r.refreshRateRatio);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
