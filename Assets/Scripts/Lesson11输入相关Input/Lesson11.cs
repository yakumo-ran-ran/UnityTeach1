using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // // print(Input.mousePosition);
        // if (Input.GetMouseButtonDown(0))
        // {
        //     print("left mouse click");
        // }
        //
        // if (Input.GetMouseButtonUp(0))
        // {
        //     print("left mouse up");
        // }
        //
        // if (Input.GetMouseButton(0))
        // {
        //     print("left mouse press");
        // }
        //
        // // print(Input.mouseScrollDelta);
        //
        // if (Input.GetKeyDown(KeyCode.W))
        // {
        //     print("W was pressed");
        // }
        //
        // if (Input.GetKeyDown("q"))
        // {
        //     print("Q was pressed");
        // }
        //
        // if (Input.GetKeyUp("q"))
        // {
        //     print("Q was up");
        // }
        // if (Input.GetKeyUp("q"))
        // {
        //     print("Q was pressing");
        // }
        // if (Input.GetKeyDown("space"))
        // {
        //     print("Space was pressed");
        // }

        // print(Input.GetAxis("Horizontal"));
        // print(Input.GetAxis("Vertical"));
        // print(Input.GetAxis("Mouse X"));

        if (Input.anyKey)
        {
            print("Start");
        }

        if (Input.anyKeyDown)
        {
            print("someone key down");
        }
        
        print(Input.inputString);
        string[]strs= Input.GetJoystickNames();


        if (Input.touchCount > 0)
        {
            Touch t1 = Input.touches[0];
            print(t1.position);//position
            print(t1.deltaPosition);//deltaposition
        }

        Input.multiTouchEnabled = true;

        Input.gyro.enabled = true;

        print(Input.gyro.gravity);
        print(Input.gyro.rotationRate);
    }
}
