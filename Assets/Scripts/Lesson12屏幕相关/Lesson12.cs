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
        print(Screen.width);
        print(Screen.height);
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.fullScreen = true;
        Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
        Screen.autorotateToLandscapeLeft = true;
        Screen.autorotateToLandscapeRight = true;
        Screen.autorotateToPortraitUpsideDown = true;
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        //Set Resolution
        // Screen.SetResolution();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
