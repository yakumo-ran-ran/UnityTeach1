using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14 : MonoBehaviour
{
    public Transform obj;
    // Start is called before the first frame update
    void Start()
    {
        print(Camera.main.name);
        print(Camera.allCamerasCount);
        Camera[] allCamera = Camera.allCameras;
        print(allCamera.Length);
        Camera.onPreCull += (c) =>
        {
            
        };
        Camera.onPreRender += (c) =>
        {
            
        };
        Camera.onPostRender += (c) =>
        {
            
        };

        Vector3 v= Camera.main.WorldToScreenPoint(transform.position);
        print(v);
        //z对应物体远近
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = Input.mousePosition;
        v.z = 10;
        print("mouse Pos"+Camera.main.ScreenToWorldPoint(v));
        obj.position = Camera.main.ScreenToWorldPoint(v);
    }
}
